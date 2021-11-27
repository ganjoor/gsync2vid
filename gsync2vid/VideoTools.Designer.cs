namespace gsync2vid
{
    partial class VideoTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCut = new System.Windows.Forms.GroupBox();
            this.btnCut = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.MaskedTextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.MaskedTextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnExtractAudio = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grmMerge = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.grpCut.SuspendLayout();
            this.grmMerge.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCut
            // 
            this.grpCut.Controls.Add(this.btnCut);
            this.grpCut.Controls.Add(this.txtEnd);
            this.grpCut.Controls.Add(this.lblEnd);
            this.grpCut.Controls.Add(this.txtStart);
            this.grpCut.Controls.Add(this.lblStart);
            this.grpCut.Location = new System.Drawing.Point(12, 12);
            this.grpCut.Name = "grpCut";
            this.grpCut.Size = new System.Drawing.Size(413, 63);
            this.grpCut.TabIndex = 0;
            this.grpCut.TabStop = false;
            this.grpCut.Text = "برش ویدیو";
            // 
            // btnCut
            // 
            this.btnCut.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCut.Location = new System.Drawing.Point(6, 23);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(138, 23);
            this.btnCut.TabIndex = 4;
            this.btnCut.Text = "انتخاب مسیر خروجی";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(150, 24);
            this.txtEnd.Mask = "00:00:00";
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnd.Size = new System.Drawing.Size(68, 21);
            this.txtEnd.TabIndex = 3;
            this.txtEnd.Text = "000100";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(224, 27);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(30, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "پایان:";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(288, 25);
            this.txtStart.Mask = "00:00:00";
            this.txtStart.Name = "txtStart";
            this.txtStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStart.Size = new System.Drawing.Size(68, 21);
            this.txtStart.TabIndex = 1;
            this.txtStart.Text = "000000";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(362, 28);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(39, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "شروع:";
            // 
            // btnExtractAudio
            // 
            this.btnExtractAudio.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnExtractAudio.Location = new System.Drawing.Point(281, 277);
            this.btnExtractAudio.Name = "btnExtractAudio";
            this.btnExtractAudio.Size = new System.Drawing.Size(138, 23);
            this.btnExtractAudio.TabIndex = 1;
            this.btnExtractAudio.Text = "استخراج صدا";
            this.btnExtractAudio.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(281, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grmMerge
            // 
            this.grmMerge.Controls.Add(this.btnAdd);
            this.grmMerge.Controls.Add(this.lstVideos);
            this.grmMerge.Controls.Add(this.btnMerge);
            this.grmMerge.Location = new System.Drawing.Point(12, 80);
            this.grmMerge.Name = "grmMerge";
            this.grmMerge.Size = new System.Drawing.Size(413, 192);
            this.grmMerge.TabIndex = 3;
            this.grmMerge.TabStop = false;
            this.grmMerge.Text = "ادغام ویدیوها";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(362, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstVideos
            // 
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.Location = new System.Drawing.Point(6, 39);
            this.lstVideos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstVideos.Size = new System.Drawing.Size(393, 108);
            this.lstVideos.TabIndex = 5;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(6, 158);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(138, 23);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.Text = "انتخاب مسیر خروجی";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // VideoTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(437, 351);
            this.Controls.Add(this.grmMerge);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExtractAudio);
            this.Controls.Add(this.grpCut);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoTools";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ابزارهای ویدیو";
            this.grpCut.ResumeLayout(false);
            this.grpCut.PerformLayout();
            this.grmMerge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCut;
        private System.Windows.Forms.MaskedTextBox txtStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.MaskedTextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnExtractAudio;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grmMerge;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstVideos;
    }
}