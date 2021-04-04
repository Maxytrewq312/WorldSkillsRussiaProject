namespace WorldSkillsRussiaProject.Администратор
{
    partial class Управление_Благотворительными_организациями
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
            this.newButton = new System.Windows.Forms.Button();
            this.organizationLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Gray;
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 14.25F);
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(38, 124);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(194, 45);
            this.newButton.TabIndex = 52;
            this.newButton.Text = "+ Добавить нового";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // organizationLayoutPanel
            // 
            this.organizationLayoutPanel.AutoScroll = true;
            this.organizationLayoutPanel.Location = new System.Drawing.Point(56, 175);
            this.organizationLayoutPanel.Name = "organizationLayoutPanel";
            this.organizationLayoutPanel.Size = new System.Drawing.Size(757, 371);
            this.organizationLayoutPanel.TabIndex = 51;
            // 
            // manageLabel
            // 
            this.manageLabel.AutoSize = true;
            this.manageLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manageLabel.ForeColor = System.Drawing.Color.Black;
            this.manageLabel.Location = new System.Drawing.Point(91, 79);
            this.manageLabel.Name = "manageLabel";
            this.manageLabel.Size = new System.Drawing.Size(678, 33);
            this.manageLabel.TabIndex = 50;
            this.manageLabel.Text = "Управление благотворительными организациями";
            this.manageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Location = new System.Drawing.Point(-2, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 68);
            this.panel2.TabIndex = 84;
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
            this.panel1.TabIndex = 83;
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
            this.button3.TabIndex = 85;
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
            this.button4.TabIndex = 86;
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
            // Управление_Благотворительными_организациями
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.organizationLayoutPanel);
            this.Controls.Add(this.manageLabel);
            this.Name = "Управление_Благотворительными_организациями";
            this.Text = "Управление_Благотворительными_организациями";
            this.Load += new System.EventHandler(this.Управление_Благотворительными_организациями_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.FlowLayoutPanel organizationLayoutPanel;
        private System.Windows.Forms.Label manageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelTime;
    }
}