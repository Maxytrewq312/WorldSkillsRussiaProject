namespace WorldSkillsRussiaProject.Бегун
{
    partial class Информация_о_спонсоре
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDesk = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(463, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 24);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelDesk
            // 
            this.labelDesk.AutoSize = true;
            this.labelDesk.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelDesk.Location = new System.Drawing.Point(12, 245);
            this.labelDesk.Name = "labelDesk";
            this.labelDesk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDesk.Size = new System.Drawing.Size(50, 18);
            this.labelDesk.TabIndex = 1;
            this.labelDesk.Text = "label2";
            this.labelDesk.Click += new System.EventHandler(this.labelDesk_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(349, 56);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(296, 169);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // Информация_о_спонсоре
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 386);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelDesk);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Информация_о_спонсоре";
            this.Text = "Информация_о_спонсоре";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelDesk;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}