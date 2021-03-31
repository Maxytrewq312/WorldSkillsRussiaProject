namespace WorldSkillsRussiaProject.Администратор
{
    partial class Управление_волонтерами
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.managerLabel = new System.Windows.Forms.Label();
            this.volunterDataGrid = new System.Windows.Forms.DataGridView();
            this.volunterNumberLabel = new System.Windows.Forms.Label();
            this.volunterLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.sortOfLabel = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.loadLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volunterDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.managerLabel.Location = new System.Drawing.Point(302, 20);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(255, 24);
            this.managerLabel.TabIndex = 82;
            this.managerLabel.Text = "Управление волонтерами";
            this.managerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volunterDataGrid
            // 
            this.volunterDataGrid.AllowUserToAddRows = false;
            this.volunterDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.volunterDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.volunterDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.volunterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.volunterDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.volunterDataGrid.EnableHeadersVisualStyles = false;
            this.volunterDataGrid.Location = new System.Drawing.Point(56, 312);
            this.volunterDataGrid.Name = "volunterDataGrid";
            this.volunterDataGrid.ReadOnly = true;
            this.volunterDataGrid.RowHeadersVisible = false;
            this.volunterDataGrid.Size = new System.Drawing.Size(744, 233);
            this.volunterDataGrid.TabIndex = 81;
            // 
            // volunterNumberLabel
            // 
            this.volunterNumberLabel.AutoSize = true;
            this.volunterNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volunterNumberLabel.Location = new System.Drawing.Point(514, 277);
            this.volunterNumberLabel.Name = "volunterNumberLabel";
            this.volunterNumberLabel.Size = new System.Drawing.Size(43, 22);
            this.volunterNumberLabel.TabIndex = 80;
            this.volunterNumberLabel.Text = "100";
            // 
            // volunterLabel
            // 
            this.volunterLabel.AutoSize = true;
            this.volunterLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volunterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.volunterLabel.Location = new System.Drawing.Point(329, 277);
            this.volunterLabel.Name = "volunterLabel";
            this.volunterLabel.Size = new System.Drawing.Size(175, 22);
            this.volunterLabel.TabIndex = 79;
            this.volunterLabel.Text = "Всего волонтеров:";
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.loadButton.Location = new System.Drawing.Point(613, 117);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(227, 39);
            this.loadButton.TabIndex = 78;
            this.loadButton.Text = "Загрузка волонтеров";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.refreshButton.Location = new System.Drawing.Point(64, 218);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(122, 39);
            this.refreshButton.TabIndex = 73;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // sortOfLabel
            // 
            this.sortOfLabel.AutoSize = true;
            this.sortOfLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortOfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sortOfLabel.Location = new System.Drawing.Point(26, 178);
            this.sortOfLabel.Name = "sortOfLabel";
            this.sortOfLabel.Size = new System.Drawing.Size(144, 22);
            this.sortOfLabel.TabIndex = 77;
            this.sortOfLabel.Text = "Сортировка по:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(204, 178);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(184, 30);
            this.sortComboBox.TabIndex = 76;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.loadLabel.Location = new System.Drawing.Point(673, 80);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(85, 22);
            this.loadLabel.TabIndex = 75;
            this.loadLabel.Text = "Загрузка";
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sortLabel.Location = new System.Drawing.Point(60, 134);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(240, 22);
            this.sortLabel.TabIndex = 74;
            this.sortLabel.Text = "Сортировка и фильтрация";
            // 
            // Управление_волонтерами
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.volunterDataGrid);
            this.Controls.Add(this.volunterNumberLabel);
            this.Controls.Add(this.volunterLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.sortOfLabel);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.sortLabel);
            this.Name = "Управление_волонтерами";
            this.Text = "Управление_волонтерами";
            this.Load += new System.EventHandler(this.Управление_волонтерами_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volunterDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.DataGridView volunterDataGrid;
        private System.Windows.Forms.Label volunterNumberLabel;
        private System.Windows.Forms.Label volunterLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label sortOfLabel;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.Label sortLabel;
    }
}