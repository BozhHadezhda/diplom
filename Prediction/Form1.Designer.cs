namespace Prediction
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surname1_ = new System.Windows.Forms.TextBox();
            this.name1_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.age1_ = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gender_ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите данные о пациенте";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(18, 103);
            this.lable4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(44, 20);
            this.lable4.TabIndex = 2;
            this.lable4.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия:";
            // 
            // surname1_
            // 
            this.surname1_.Location = new System.Drawing.Point(111, 58);
            this.surname1_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surname1_.Name = "surname1_";
            this.surname1_.Size = new System.Drawing.Size(229, 26);
            this.surname1_.TabIndex = 4;
            this.surname1_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname1__KeyPress);
            // 
            // name1_
            // 
            this.name1_.Location = new System.Drawing.Point(111, 98);
            this.name1_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name1_.Name = "name1_";
            this.name1_.Size = new System.Drawing.Size(229, 26);
            this.name1_.TabIndex = 5;
            this.name1_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name1__KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Возраст:";
            // 
            // age1_
            // 
            this.age1_.Location = new System.Drawing.Point(111, 138);
            this.age1_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.age1_.Name = "age1_";
            this.age1_.Size = new System.Drawing.Size(49, 26);
            this.age1_.TabIndex = 10;
            this.age1_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age1__KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 228);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Пол:";
            // 
            // gender_
            // 
            this.gender_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_.FormattingEnabled = true;
            this.gender_.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.gender_.Location = new System.Drawing.Point(279, 138);
            this.gender_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gender_.Name = "gender_";
            this.gender_.Size = new System.Drawing.Size(61, 28);
            this.gender_.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(476, 282);
            this.Controls.Add(this.gender_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.age1_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name1_);
            this.Controls.Add(this.surname1_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прогнозирование осложнений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surname1_;
        private System.Windows.Forms.TextBox name1_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox age1_;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox gender_;
    }
}

