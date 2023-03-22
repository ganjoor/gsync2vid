namespace gsync2vid
{
    partial class RecitationsMerger
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
            this.grmMerge = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstRecitations = new System.Windows.Forms.ListBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.grmMerge.SuspendLayout();
            this.SuspendLayout();
            // 
            // grmMerge
            // 
            this.grmMerge.Controls.Add(this.btnAdd);
            this.grmMerge.Controls.Add(this.lstRecitations);
            this.grmMerge.Controls.Add(this.btnMerge);
            this.grmMerge.Location = new System.Drawing.Point(7, 3);
            this.grmMerge.Name = "grmMerge";
            this.grmMerge.Size = new System.Drawing.Size(413, 199);
            this.grmMerge.TabIndex = 4;
            this.grmMerge.TabStop = false;
            this.grmMerge.Text = "ادغام خوانش‌ها";
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
            // lstRecitations
            // 
            this.lstRecitations.FormattingEnabled = true;
            this.lstRecitations.Location = new System.Drawing.Point(6, 39);
            this.lstRecitations.Margin = new System.Windows.Forms.Padding(2);
            this.lstRecitations.Name = "lstRecitations";
            this.lstRecitations.Size = new System.Drawing.Size(393, 108);
            this.lstRecitations.TabIndex = 5;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(6, 158);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(138, 23);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.Text = "تولید خروجی";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // RecitationsMerger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 218);
            this.Controls.Add(this.grmMerge);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecitationsMerger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادغام خوانش‌ها";
            this.grmMerge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grmMerge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstRecitations;
        private System.Windows.Forms.Button btnMerge;
    }
}