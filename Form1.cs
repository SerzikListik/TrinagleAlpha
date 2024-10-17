using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Треугольники
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения из полей ввода
            
            int a, b, c; //Стороны треугольника

            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = int.Parse(textBox3.Text);
            }
            catch 
            {
                MessageBox.Show("Введите целые числа в поля ввода!", "Ошибка!");
                return;
            }

            // Проверяем, являются ли стороны треугольника
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Из этих сторон нельзя построить треугольник т.к. нарушаеться определение треугольника и его сторон.", "Ошибка!");
                return;
            }

            // Определяем вид треугольника
            if (a == b && b == c)
            {
                MessageBox.Show("Треугольник равносторонний");
            }

           else if (a == b || b == c || a==c)
            {
                MessageBox.Show("Треугольник равнобедренный");
            }

            else
            {
                MessageBox.Show("Треугольник разносторонний");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
