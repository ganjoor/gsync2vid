
using ganjoor.Utilities;
using ganjoor;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System;
using System.IO;
using gsync2vid.Properties;
using DocumentFormat.OpenXml.Presentation;

namespace gsync2vid
{
    public partial class RecitationsMerger : Form
    {
        public RecitationsMerger(int poemId = 0, DbBrowser db = null)
        {
            InitializeComponent();

            PoemId = poemId;
            Db = db;
        }

        public int PoemId { get; set; }

        public DbBrowser Db { get; set; }


        private void btnAdd_Click(object sender, System.EventArgs e)
        {
           
            PoemAudio[] audios = Db.GetPoemAudioFiles(PoemId);

            List<PoemAudio> selectables = new List<PoemAudio>();
            foreach (var audio  in audios)
            {
                bool alreadyAdded = false;
                foreach (var item in lstRecitations.Items)
                {
                    if((item as PoemAudio).Id == audio.Id)
                    {
                        alreadyAdded = true;
                        break;
                    }
                }
                if(!alreadyAdded)
                {
                    selectables.Add(audio);
                }
            }

            if (selectables.Count == 0)
            {
                GMessageBox.SayError("خوانش قابل انتخابی وجود ندارد.");
            }
            else
            {
                using (ItemSelector audioSelector = new ItemSelector("انتخاب خوانش", selectables.ToArray(), selectables.First()))
                {
                    if (audioSelector.ShowDialog(this) == DialogResult.OK)
                    {
                        lstRecitations.Items.Add(audioSelector.SelectedItem);
                    }
                }
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if(lstRecitations.Items.Count < 2)
            {
                GMessageBox.SayError("دست کم دو خوانش را انتخاب کنید.");
                return;
            }
            using(SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "MP3 Files (*.mp3)|*.mp3";
                if(dlg.ShowDialog(this) == DialogResult.OK)
                {
                    int addInMiliseconds = 0;
                    PoemAudio firstItem = lstRecitations.Items[0] as PoemAudio;
                    PoemAudio merged = new PoemAudio()
                    {
                        Id = firstItem.Id,
                        PoemId = PoemId,
                        FilePath = dlg.FileName,
                        SyncGuid = Guid.NewGuid(),
                        Description = firstItem.Description,
                        DownloadUrl = "",
                        IsDirectlyDownloadable = false,
                        IsUploaded = false
                    };
                    List<PoemAudio.SyncInfo> syncs = new List<PoemAudio.SyncInfo>();
                    foreach (PoemAudio item in lstRecitations.Items)
                    {
                        PoemAudioPlayer player = new PoemAudioPlayer();
                        if (!player.BeginPlayback(item))
                        {
                            GMessageBox.SayError($"تلاش برای دسترسی و پخش فایل صوتی موفق نبود - {item}");
                            return;
                        }
                        else
                        {
                            player.StopPlayBack();

                            int nLen = item.SyncArray.Length;
                            if (item.SyncArray[nLen - 1].AudioMiliseconds > player.TotalTimeInMiliseconds)
                            {
                                for (int i = 0; i < nLen; i++)
                                {
                                    item.SyncArray[i].AudioMiliseconds = item.SyncArray[i].AudioMiliseconds / 2;
                                }
                            }

                            for (int i = 0; i < nLen; i++)
                            {
                                item.SyncArray[i].AudioMiliseconds += addInMiliseconds;
                                syncs.Add(item.SyncArray[i]);
                            }


                            addInMiliseconds += player.TotalTimeInMiliseconds;
                        }
                    }
                    merged.SyncArray = syncs.ToArray();
                    List<string> lines = new List<string>();
                    foreach (PoemAudio item in lstRecitations.Items)
                    {
                        lines.Add($"file '{item.FilePath}'");
                    }

                    string strTempList = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".txt");
                    File.WriteAllLines(strTempList, lines.ToArray());

                    string outFileName = dlg.FileName;

                    string ffmpegPath = Settings.Default.FFmpegPath;

                    string cmdArgs = $"-f concat -safe 0 -i \"{strTempList}\" -c copy \"{outFileName}\"";

                    ProcessStartInfo ps = new ProcessStartInfo
                        (
                        Path.Combine(ffmpegPath, "ffmpeg.exe")
                        ,
                        cmdArgs
                        );

                    ps.UseShellExecute = false;

                    var ffmpegPs = Process.Start(ps);

                    ffmpegPs.WaitForExit();

                    File.Delete(strTempList);

                    if (File.Exists(outFileName))
                    {
                        merged.FileCheckSum = PoemAudio.ComputeCheckSum(outFileName);
                        PoemAudioListProcessor.Save(Path.Combine(Path.GetDirectoryName(outFileName), Path.GetFileNameWithoutExtension(outFileName) + ".xml"), merged, false);
                        GMessageBox.Announce("ذخیره شد.");
                    }
                    else
                    {
                        MessageBox.Show("فایل خروجی ایجاد نشد.", "خطا", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
