using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tab_CalcPage);
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(countWorkDay_textBox.Text, out int count_WorkDay);
            CountSalary cs = new CountSalary(Name_textBox.Text, count_WorkDay, mounth_textBox.Text);
            tabControl.TabPages.Add(tab_CalcPage);
            tabControl.SelectTab(tab_CalcPage);
            tabControl.TabPages.Remove(tab_MainPage);
            label_name.Text = Name_textBox.Text + " отработал(а) " + count_WorkDay + " дней." + "\n\nВведите количество человек и часов:";
            FillPanel();
        }

        private void FillPanel() 
        {
            Label textPeople = new Label
            {
                Left = 232,
                Top = 35,
                Width = 55,
                Parent = tab_CalcPage,
                Text = Convert.ToString("человек:")
            };
            
            Label textHours = new Label
            {
                Left = 295,
                Top = 35,
                Width = 55,
                Parent = tab_CalcPage,
                Text = Convert.ToString("часов:")
            };


            //TextBox[] tb = new TextBox[Convert.ToInt32(countWorkDay_textBox.Text)];

            //for (int i = 0; i < tb.Length; i++)
            //{
            //    int t = i * 25;
            //    tb[i] = new TextBox();
            //    Left = 255;
            //    Top = 60 + t;
            //    Width = 20;
            //    Parent = tab_CalcPage;
            //    Tag = i;
            //    Controls.Add(tb[i]);
            //}

            for (int i = 0; i < Convert.ToInt32(countWorkDay_textBox.Text); i++)
            {
                int t = i * 25;

                //Label ls = new Label
                //{
                //    Left = 330,
                //    Top = 65 + t,
                //    Width = 22,
                //    Parent = tab_CalcPage,
                //    Tag = i
                //};

                Label text = new Label
                {
                    Left = 230,
                    Top = 65 + t,
                    Width = 22,
                    Parent = tab_CalcPage,
                    Text = Convert.ToString((i+1) + ".")
                };

                TextBox tb_people = new TextBox
                {
                    Left = 255,
                    Top = 60 + t,
                    Width = 20,
                    Parent = tab_CalcPage,
                    Tag = i,
                    //Text = Convert.ToString(null)
                };
                tb_people.TextChanged += TbPeople_TextChanged;
                
                TextBox tb_hours = new TextBox
                {
                    Left = 308,
                    Top = 60 + t,
                    Width = 20,
                    Parent = tab_CalcPage,
                    Tag = i,
                    //Text = Convert.ToString(null)
                };
                tb_hours.TextChanged += TbHours_TextChanged;
            }
        }

        private int id_people;
        private int id_hours;
        private int id_label;

        CountSalary cs = new CountSalary();

        private int sum = 0; // Сумма отдельных дней.
        private int people;
        private int hours;
        private int salary_allDay;

        public int Hours { get => hours; set => hours = value; }
        public int People { get => people; set => people = value; }
        public int Salary_oneDay { get => sum; set => sum = value; }
        public int Salary_allDay { get => salary_allDay; set => salary_allDay = value; }

        public void TbPeople_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox))
                return;

            // ID, какой по счету день.
            id_people = Convert.ToInt32(textBox.Tag);  
            
            // ID label'а, с таким же тэгом дня, за который идет подсчёт.
            //id_label = Convert.ToInt32(textBox.Tag);

            // Выбор из строки числовых значений. Если строка пустая, то присвоить 0.
            if (!int.TryParse(textBox.Text, out int count_people)) 
                count_people = 0;

            // количество людей в этот день.
            People = count_people;

            // Подсчет зарплаты за один день.   (?)
            //if (id_hours == id_people) 
            {
                Salary_oneDay = cs.Add(Hours, People);
            }
            //Salary_allDay += Salary_oneDay;
        }

        public void TbHours_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox))
                return;

            // ID, какой по счету день.
            id_hours = Convert.ToInt32(textBox.Tag);

            // Выбор из строки числовых значений. Если строка пустая, то присвоить 0.
            if (!int.TryParse(textBox.Text, out int count_hours)) 
                count_hours = 0;

            // Количество часов в этот день.
            Hours = count_hours;

            // Подсчет зарплаты за один день.   (?)
            if (id_hours == id_people)
            {
                Salary_oneDay = cs.Add(Hours, People);
            }
            //Salary_allDay += Salary_oneDay;
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Convert.ToInt32(countWorkDay_textBox.Text); i++)
            //{
            //    //if (TextBox.Tag == TextBox.Tag)
            //    //{
            //    //    Sum = cs.Add(Hours, People);
            //    //}
            //}
            //if (tb_people.Tag == tb_hours.Tag)
            //{
            //    textBox.Text
            //}
            
            // Подсчет зарплаты за все дни.
            label_sum.Text = $"Зарплата = {Salary_oneDay}";
        }
    }
}
