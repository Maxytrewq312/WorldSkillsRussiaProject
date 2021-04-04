namespace WorldSkillsRussiaProject.Администратор
{
    partial class Загрузка_волонтеров
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.csvDataGrid = new System.Windows.Forms.DataGridView();
            this.cvsMustHaveLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.csvLabel = new System.Windows.Forms.Label();
            this.volunterLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.csvDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // csvDataGrid
            // 
            this.csvDataGrid.AllowUserToAddRows = false;
            this.csvDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.csvDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.csvDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csvDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.csvDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.csvDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.csvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.csvDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.csvDataGrid.EnableHeadersVisualStyles = false;
            this.csvDataGrid.Location = new System.Drawing.Point(291, 359);
            this.csvDataGrid.Name = "csvDataGrid";
            this.csvDataGrid.ReadOnly = true;
            this.csvDataGrid.RowHeadersVisible = false;
            this.csvDataGrid.Size = new System.Drawing.Size(289, 169);
            this.csvDataGrid.TabIndex = 86;
            // 
            // cvsMustHaveLabel
            // 
            this.cvsMustHaveLabel.AutoSize = true;
            this.cvsMustHaveLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvsMustHaveLabel.ForeColor = System.Drawing.Color.Black;
            this.cvsMustHaveLabel.Location = new System.Drawing.Point(217, 312);
            this.cvsMustHaveLabel.Name = "cvsMustHaveLabel";
            this.cvsMustHaveLabel.Size = new System.Drawing.Size(423, 27);
            this.cvsMustHaveLabel.TabIndex = 85;
            this.cvsMustHaveLabel.Text = "CSV должен иметь следующие поля:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(439, 225);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 39);
            this.cancelButton.TabIndex = 84;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Gray;
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(312, 225);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(109, 39);
            this.loadButton.TabIndex = 79;
            this.loadButton.Text = "Загрузка";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.BackColor = System.Drawing.Color.Gray;
            this.fileButton.FlatAppearance.BorderSize = 0;
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileButton.ForeColor = System.Drawing.Color.White;
            this.fileButton.Location = new System.Drawing.Point(630, 152);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(121, 29);
            this.fileButton.TabIndex = 80;
            this.fileButton.Text = "Просмотр...";
            this.fileButton.UseVisualStyleBackColor = false;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileTextBox.ForeColor = System.Drawing.Color.Black;
            this.fileTextBox.Location = new System.Drawing.Point(365, 152);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(249, 29);
            this.fileTextBox.TabIndex = 83;
            // 
            // csvLabel
            // 
            this.csvLabel.AutoSize = true;
            this.csvLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.csvLabel.ForeColor = System.Drawing.Color.Black;
            this.csvLabel.Location = new System.Drawing.Point(99, 154);
            this.csvLabel.Name = "csvLabel";
            this.csvLabel.Size = new System.Drawing.Size(270, 27);
            this.csvLabel.TabIndex = 82;
            this.csvLabel.Text = "CSV файл волонтеров:";
            // 
            // volunterLabel
            // 
            this.volunterLabel.AutoSize = true;
            this.volunterLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volunterLabel.ForeColor = System.Drawing.Color.Black;
            this.volunterLabel.Location = new System.Drawing.Point(285, 97);
            this.volunterLabel.Name = "volunterLabel";
            this.volunterLabel.Size = new System.Drawing.Size(295, 33);
            this.volunterLabel.TabIndex = 81;
            this.volunterLabel.Text = "Загрузка волонтеров\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Location = new System.Drawing.Point(-2, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 68);
            this.panel2.TabIndex = 88;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(15, 25);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(825, 18);
            this.labelTime.TabIndex = 15;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 68);
            this.panel1.TabIndex = 87;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(15, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 44);
            this.button3.TabIndex = 89;
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
            this.button4.Location = new System.Drawing.Point(722, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 44);
            this.button4.TabIndex = 90;
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
            // Загрузка_волонтеров
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.csvDataGrid);
            this.Controls.Add(this.cvsMustHaveLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.csvLabel);
            this.Controls.Add(this.volunterLabel);
            this.Name = "Загрузка_волонтеров";
            this.Text = "Загрузка_волонтеров";
            ((System.ComponentModel.ISupportInitialize)(this.csvDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView csvDataGrid;
        private System.Windows.Forms.Label cvsMustHaveLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label csvLabel;
        private System.Windows.Forms.Label volunterLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelTime;
    }
}