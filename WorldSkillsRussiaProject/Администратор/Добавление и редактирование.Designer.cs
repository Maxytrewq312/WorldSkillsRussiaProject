namespace WorldSkillsRussiaProject.Администратор
{
    partial class Добавление_и_редактирование
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Добавление_и_редактирование));
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.descriptionFileLabel = new System.Windows.Forms.Label();
            this.photoButton = new System.Windows.Forms.Button();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.photoLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.charityLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(418, 508);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 37);
            this.cancelButton.TabIndex = 80;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gray;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(261, 508);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 37);
            this.saveButton.TabIndex = 68;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.Black;
            this.logoLabel.Location = new System.Drawing.Point(462, 300);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(159, 22);
            this.logoLabel.TabIndex = 78;
            this.logoLabel.Text = "Текущий логотип:";
            // 
            // descriptionFileLabel
            // 
            this.descriptionFileLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionFileLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionFileLabel.Location = new System.Drawing.Point(424, 162);
            this.descriptionFileLabel.Name = "descriptionFileLabel";
            this.descriptionFileLabel.Size = new System.Drawing.Size(401, 67);
            this.descriptionFileLabel.TabIndex = 77;
            this.descriptionFileLabel.Text = "Оставьте поле \"Логотип файл\" пустым\r\nесли вы не хотете загружать логотип";
            this.descriptionFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // photoButton
            // 
            this.photoButton.BackColor = System.Drawing.Color.Gray;
            this.photoButton.FlatAppearance.BorderSize = 0;
            this.photoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.photoButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoButton.ForeColor = System.Drawing.Color.White;
            this.photoButton.Location = new System.Drawing.Point(663, 252);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(122, 30);
            this.photoButton.TabIndex = 76;
            this.photoButton.Text = "Просмотр...";
            this.photoButton.UseVisualStyleBackColor = false;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // photoTextBox
            // 
            this.photoTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.photoTextBox.ForeColor = System.Drawing.Color.Black;
            this.photoTextBox.Location = new System.Drawing.Point(466, 253);
            this.photoTextBox.Multiline = true;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(191, 30);
            this.photoTextBox.TabIndex = 75;
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.ForeColor = System.Drawing.Color.Black;
            this.photoLabel.Location = new System.Drawing.Point(477, 228);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(110, 22);
            this.photoLabel.TabIndex = 74;
            this.photoLabel.Text = "Фото файл:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(29, 286);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(400, 201);
            this.descriptionTextBox.TabIndex = 73;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(25, 254);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 22);
            this.descriptionLabel.TabIndex = 72;
            this.descriptionLabel.Text = "Описание:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(29, 200);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 32);
            this.nameTextBox.TabIndex = 71;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(25, 175);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(144, 22);
            this.nameLabel.TabIndex = 70;
            this.nameLabel.Text = "Наименование:";
            // 
            // charityLabel
            // 
            this.charityLabel.AutoSize = true;
            this.charityLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charityLabel.ForeColor = System.Drawing.Color.Black;
            this.charityLabel.Location = new System.Drawing.Point(165, 80);
            this.charityLabel.Name = "charityLabel";
            this.charityLabel.Size = new System.Drawing.Size(492, 72);
            this.charityLabel.TabIndex = 69;
            this.charityLabel.Text = "Добавление/Редактирование\r\nблаготворительных организаций\r\n";
            this.charityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.logoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.BackgroundImage")));
            this.logoPictureBox.Location = new System.Drawing.Point(466, 336);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(241, 151);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 79;
            this.logoPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Location = new System.Drawing.Point(1, 563);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 68);
            this.panel2.TabIndex = 82;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 25);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(831, 18);
            this.labelTime.TabIndex = 15;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 68);
            this.panel1.TabIndex = 81;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 44);
            this.button3.TabIndex = 83;
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
            this.button4.Location = new System.Drawing.Point(725, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 44);
            this.button4.TabIndex = 84;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maraphon World Skills Russia";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Добавление_и_редактирование
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.descriptionFileLabel);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(this.photoLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.charityLabel);
            this.Name = "Добавление_и_редактирование";
            this.Text = "Добавление_и_редактирование";
            this.Load += new System.EventHandler(this.Добавление_и_редактирование_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label descriptionFileLabel;
        private System.Windows.Forms.Button photoButton;
        public System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Label photoLabel;
        public System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label charityLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelTime;
    }
}