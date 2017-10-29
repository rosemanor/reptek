namespace UI.Forms
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelMainProjTitle = new System.Windows.Forms.Label();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.labelVerssion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(66, 67);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelMainProjTitle
            // 
            this.labelMainProjTitle.AutoSize = true;
            this.labelMainProjTitle.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.labelMainProjTitle.ForeColor = System.Drawing.Color.DarkKhaki;
            this.labelMainProjTitle.Location = new System.Drawing.Point(132, 12);
            this.labelMainProjTitle.Name = "labelMainProjTitle";
            this.labelMainProjTitle.Size = new System.Drawing.Size(280, 67);
            this.labelMainProjTitle.TabIndex = 1;
            this.labelMainProjTitle.Text = "Pure MIDI";
            // 
            // labelProgramName
            // 
            this.labelProgramName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgramName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProgramName.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.labelProgramName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelProgramName.Location = new System.Drawing.Point(84, 79);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(368, 39);
            this.labelProgramName.TabIndex = 3;
            this.labelProgramName.Text = "MONITOR";
            this.labelProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInfo.Location = new System.Drawing.Point(12, 131);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(342, 128);
            this.textBoxInfo.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DimGray;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(360, 233);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 26);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
            // 
            // buttonDonate
            // 
            this.buttonDonate.BackColor = System.Drawing.Color.DimGray;
            this.buttonDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonate.Location = new System.Drawing.Point(360, 201);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(92, 26);
            this.buttonDonate.TabIndex = 6;
            this.buttonDonate.Text = "Donate";
            this.buttonDonate.UseVisualStyleBackColor = false;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // labelVerssion
            // 
            this.labelVerssion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelVerssion.Location = new System.Drawing.Point(12, 269);
            this.labelVerssion.Name = "labelVerssion";
            this.labelVerssion.Size = new System.Drawing.Size(440, 14);
            this.labelVerssion.TabIndex = 8;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 291);
            this.Controls.Add(this.labelVerssion);
            this.Controls.Add(this.buttonDonate);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelProgramName);
            this.Controls.Add(this.labelMainProjTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelMainProjTitle;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDonate;
        private System.Windows.Forms.Label labelVerssion;
    }
}