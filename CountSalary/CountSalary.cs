using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountSalary
{
    public class CountSalary
    {
        private string _nameForSalary = "";
        private int _countWorkDay = 0;
        private int _numberOfHours = 0;
        private int _numberOfPeople = 0;
        private string _monthSalary = "";

        /// <summary>
        /// Конструктор для присваивания переменных с информацией полиграфолога.
        /// </summary>
        /// <param name="nameForSalary">Имя полиграфолога.</param>
        /// <param name="countWorkDay">Количество дней, которые отработал полиграфолог.</param>
        /// <param name="countWorkDay">Месяц, за ко</param>
        public CountSalary(string nameForSalary, int countWorkDay, string monthSalary)
        {
            NameForSalary = nameForSalary;
            CountWorkDay = countWorkDay;
            MonthSalary = monthSalary;
        }

        public string NameForSalary
        {
            get { return _nameForSalary; }
            set
            {
                if (value.Length == 0)
                {
                    MessageBox.Show("Имя слишком короткое.");
                }
                else if (value.Length > 15)
                {
                    MessageBox.Show("Имя слишком длинное(больше 20 символов).");
                }
                else 
                    _nameForSalary = value;
            }
        }

        public int CountWorkDay
        {
            get { return _countWorkDay; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Введите количество дней больше 0");
                }
                else
                    _countWorkDay = value;
            }
        }

        public int NumberOfHours
        {
            get { return _numberOfHours; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Введите количество часов больше 0");
                }
                else
                    _numberOfHours = value;
            }
        }

        public int NumberOfPeople
        {
            get { return _numberOfPeople; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Введите количество человек больше 0");
                }
                else
                    _numberOfPeople = value;
            }
        }

        public string MonthSalary
        {
            get { return _monthSalary; }
            set
            {
                if (value.Length == 0)
                {
                    MessageBox.Show("Какой месяц?");
                }
                else
                    _monthSalary = value;
            }
        }
    }
}
