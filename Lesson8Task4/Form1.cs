using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8Task4
{

    //    Задание 4
    //Используя Visual Studio, создайте проект по шаблону WindowsForms.
    //Напишите программу, в который пользователь в textBox1 и textBox2 вводит данные и выбирает при
    //помощи нескольких radioButton тип операции, которую требуется выполнить: остаток от деления,
    //возведение в степень, конкатенация, деление.Результат выводится в textBox3 при нажатии на кнопку
    //«Вычислить»

    public partial class Form1 : Form
    {

        int num1;
        int num2;

        bool isBox1Num;
        bool isBox2Num;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            isBox1Num = int.TryParse(textBox1.Text.Trim(), out num1);
            isBox2Num = int.TryParse(textBox2.Text.Trim(), out num2);

            if (isBox1Num && isBox2Num)
            {
                if (rbRemainder.Checked)
                {
                    int ans = num1 % num2;
                    textBox3.Text = ans.ToString();
                }
                else if (rbExp.Checked)
                {
                    double ans = Math.Pow(num1, num2);
                    textBox3.Text = ans.ToString();
                }
                else if (rbConcat.Checked)
                {

                    textBox3.Text = num1.ToString() + num2.ToString();
                }
                else if (rbDiv.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Connot be divided by zero.");
                    }
                    else
                    {
                        double ans = (double)num1 / num2;

                        textBox3.Text = ans.ToString().Substring(0, 15);
                    }
                }
                else if (rbClear.Checked)
                {
                    textBox1.ResetText();
                    textBox2.ResetText();
                    textBox3.ResetText();
                }
                else
                {
                    MessageBox.Show("Choose som radioButton");
                }
            }
            else if (isBox1Num && !isBox2Num)
            {
                MessageBox.Show("Your second value is not the correct number.");
            }
            else if (!isBox1Num && isBox2Num)
            {
                MessageBox.Show("Your first value is not the correct number.");
            }
            else if (!isBox1Num && !isBox2Num)
            {
                MessageBox.Show("Both of your's values are the correct numbers.");
            }
        }
    }
}
