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



        private void button1_Click(object sender, EventArgs e)
        {
            CountSalary cs = new CountSalary(Name_textBox.Text, Convert.ToInt32(countWorkDay_textBox.Text), mounth_textBox.Text);
            //panel_calculation.Visible = true;
            //tab_MainPage.Visible = false;
            tabControl.TabPages.Add(tab_CalcPage);
            tabControl.SelectTab(tab_CalcPage);
            tabControl.TabPages.Remove(tab_MainPage);

            label_name.Text = Name_textBox.Text + " отработал(а) " + countWorkDay_textBox.Text + " дней." + "\n\nВведите количество человек и часов:";
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

            Label textHour = new Label
            {
                Left = 295,
                Top = 35,
                Width = 55,
                Parent = tab_CalcPage,
                Text = Convert.ToString("часов:")
            };

            for (int i = 0; i < Convert.ToInt32(countWorkDay_textBox.Text); i++)
            {
                int t = i * 25;

                Label text = new Label
                {
                    Left = 230,
                    Top = 65 + t,
                    Width = 22,
                    Parent = tab_CalcPage,
                    Text = Convert.ToString((i+1) + ".")
                };

                TextBox tb = new TextBox
                {
                    Left = 255,
                    Top = 60 + t,
                    Width = 20,
                    Parent = tab_CalcPage,
                    Tag = i
                };
                tb.TextChanged += Tb_TextChanged;

                TextBox tb2 = new TextBox
                {
                    Left = 308,
                    Top = 60 + t,
                    Width = 20,
                    Parent = tab_CalcPage,
                    //Tag = i
                };
                tb2.TextChanged += Tb2_TextChanged;
            }
            
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox))
                return;
            //sum_label = (25 + (2 * Convert.ToInt32(textBox.Text))
            MessageBox.Show($"Элемент {textBox.Tag} = {textBox.Text}");
        }

        private void Tb2_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox textBox))
                return;
            MessageBox.Show($"Элемент {textBox.Tag} = {textBox.Text}");
        }
    }
}
