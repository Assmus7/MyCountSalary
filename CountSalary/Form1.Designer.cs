namespace CountSalary
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countWorkDay_textBox = new System.Windows.Forms.TextBox();
            this.button_main = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mounth_textBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_MainPage = new System.Windows.Forms.TabPage();
            this.tab_CalcPage = new System.Windows.Forms.TabPage();
            this.label_sum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tab_MainPage.SuspendLayout();
            this.tab_CalcPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия, Имя:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(128, 15);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(139, 20);
            this.Name_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во рабочий дней:";
            // 
            // countWorkDay_textBox
            // 
            this.countWorkDay_textBox.Location = new System.Drawing.Point(128, 55);
            this.countWorkDay_textBox.Name = "countWorkDay_textBox";
            this.countWorkDay_textBox.Size = new System.Drawing.Size(75, 20);
            this.countWorkDay_textBox.TabIndex = 4;
            // 
            // button_main
            // 
            this.button_main.Location = new System.Drawing.Point(128, 172);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(75, 23);
            this.button_main.TabIndex = 1;
            this.button_main.Text = "Ок";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.button_main_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 17);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(118, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "имя, количество дней";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Месяц";
            // 
            // mounth_textBox
            // 
            this.mounth_textBox.Location = new System.Drawing.Point(128, 96);
            this.mounth_textBox.Name = "mounth_textBox";
            this.mounth_textBox.Size = new System.Drawing.Size(111, 20);
            this.mounth_textBox.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tab_MainPage);
            this.tabControl.Controls.Add(this.tab_CalcPage);
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(-2, 11);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(495, 363);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 6;
            this.tabControl.TabStop = false;
            // 
            // tab_MainPage
            // 
            this.tab_MainPage.Controls.Add(this.mounth_textBox);
            this.tab_MainPage.Controls.Add(this.label1);
            this.tab_MainPage.Controls.Add(this.label3);
            this.tab_MainPage.Controls.Add(this.Name_textBox);
            this.tab_MainPage.Controls.Add(this.label2);
            this.tab_MainPage.Controls.Add(this.countWorkDay_textBox);
            this.tab_MainPage.Controls.Add(this.button1);
            this.tab_MainPage.Location = new System.Drawing.Point(4, 5);
            this.tab_MainPage.Name = "tab_MainPage";
            this.tab_MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MainPage.Size = new System.Drawing.Size(487, 354);
            this.tab_MainPage.TabIndex = 0;
            this.tab_MainPage.Text = "MainPage";
            this.tab_MainPage.UseVisualStyleBackColor = true;
            // 
            // tab_CalcPage
            // 
            this.tab_CalcPage.AutoScroll = true;
            this.tab_CalcPage.Controls.Add(this.label_sum);
            this.tab_CalcPage.Controls.Add(this.label4);
            this.tab_CalcPage.Controls.Add(this.button_main);
            this.tab_CalcPage.Controls.Add(this.label_name);
            this.tab_CalcPage.Location = new System.Drawing.Point(4, 5);
            this.tab_CalcPage.Name = "tab_CalcPage";
            this.tab_CalcPage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CalcPage.Size = new System.Drawing.Size(487, 354);
            this.tab_CalcPage.TabIndex = 1;
            this.tab_CalcPage.Text = "CalcPage";
            this.tab_CalcPage.UseVisualStyleBackColor = true;
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(11, 240);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(40, 13);
            this.label_sum.TabIndex = 7;
            this.label_sum.Text = "сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(228, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Нажмите Tab, для перехода к следующему дню";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 394);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountSalary";
            this.tabControl.ResumeLayout(false);
            this.tab_MainPage.ResumeLayout(false);
            this.tab_MainPage.PerformLayout();
            this.tab_CalcPage.ResumeLayout(false);
            this.tab_CalcPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countWorkDay_textBox;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.TextBox mounth_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_MainPage;
        private System.Windows.Forms.TabPage tab_CalcPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_sum;
    }
}

