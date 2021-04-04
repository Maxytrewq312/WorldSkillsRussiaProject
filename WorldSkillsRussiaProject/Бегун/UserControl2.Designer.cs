namespace WorldSkillsRussiaProject.Бегун
{
    partial class UserControl2
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.moneyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.moneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.moneyLabel.Location = new System.Drawing.Point(198, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(107, 27);
            this.moneyLabel.TabIndex = 51;
            this.moneyLabel.Text = "$888899";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(215, 27);
            this.nameLabel.TabIndex = 50;
            this.nameLabel.Text = "Спонсор";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(303, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
