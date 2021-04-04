namespace WorldSkillsRussiaProject.Бегун
{
    partial class Мои_спонсоры
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.linePanel = new System.Windows.Forms.Panel();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.sponsorTextLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.sponsorLabel = new System.Windows.Forms.Label();
            this.organizationPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.organizationPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(515, 240);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(302, 146);
            this.flowLayoutPanel.TabIndex = 61;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(515, 419);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(302, 27);
            this.totalLabel.TabIndex = 60;
            this.totalLabel.Text = "Всего";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linePanel
            // 
            this.linePanel.BackColor = System.Drawing.Color.Silver;
            this.linePanel.Location = new System.Drawing.Point(515, 392);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(302, 10);
            this.linePanel.TabIndex = 59;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.moneyLabel.ForeColor = System.Drawing.Color.Black;
            this.moneyLabel.Location = new System.Drawing.Point(740, 209);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(77, 27);
            this.moneyLabel.TabIndex = 58;
            this.moneyLabel.Text = "Взнос";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sponsorTextLabel
            // 
            this.sponsorTextLabel.AutoSize = true;
            this.sponsorTextLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.sponsorTextLabel.ForeColor = System.Drawing.Color.Black;
            this.sponsorTextLabel.Location = new System.Drawing.Point(518, 209);
            this.sponsorTextLabel.Name = "sponsorTextLabel";
            this.sponsorTextLabel.Size = new System.Drawing.Size(107, 27);
            this.sponsorTextLabel.TabIndex = 57;
            this.sponsorTextLabel.Text = "Спонсор";
            this.sponsorTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(39, 408);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(365, 134);
            this.descriptionTextBox.TabIndex = 56;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(34, 195);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(370, 54);
            this.infoLabel.TabIndex = 54;
            this.infoLabel.Text = "Наименование\r\nблаготворительной организации\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descriptionLabel.Location = new System.Drawing.Point(166, 141);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(521, 22);
            this.descriptionLabel.TabIndex = 53;
            this.descriptionLabel.Text = "Здесь показаны все ваши спонсоры в Marathon Skills 2021";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sponsorLabel
            // 
            this.sponsorLabel.AutoSize = true;
            this.sponsorLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sponsorLabel.Location = new System.Drawing.Point(298, 82);
            this.sponsorLabel.Name = "sponsorLabel";
            this.sponsorLabel.Size = new System.Drawing.Size(269, 42);
            this.sponsorLabel.TabIndex = 52;
            this.sponsorLabel.Text = "Мои спонсоры";
            // 
            // organizationPictureBox
            // 
            this.organizationPictureBox.Location = new System.Drawing.Point(39, 252);
            this.organizationPictureBox.Name = "organizationPictureBox";
            this.organizationPictureBox.Size = new System.Drawing.Size(365, 150);
            this.organizationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.organizationPictureBox.TabIndex = 55;
            this.organizationPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Location = new System.Drawing.Point(1, 557);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 68);
            this.panel2.TabIndex = 63;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(11, 25);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(826, 18);
            this.labelTime.TabIndex = 15;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 68);
            this.panel1.TabIndex = 62;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(4, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 44);
            this.button3.TabIndex = 64;
            this.button3.Text = "Вернуться";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(719, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 44);
            this.button4.TabIndex = 65;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(287, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maraphon World Skills Russia";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Мои_спонсоры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.sponsorTextLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.organizationPictureBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.sponsorLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Мои_спонсоры";
            this.Text = "Мои_спонсоры";
            this.Load += new System.EventHandler(this.Мои_спонсоры_Load);
            ((System.ComponentModel.ISupportInitialize)(this.organizationPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label sponsorTextLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox organizationPictureBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label sponsorLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelTime;
    }
}