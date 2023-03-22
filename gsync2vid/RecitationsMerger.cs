
using ganjoor.Utilities;
using ganjoor;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

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
    }
}
