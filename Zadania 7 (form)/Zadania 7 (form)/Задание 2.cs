using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_7__form_
{
    public partial class Задание_2 : Form
    {
        public Задание_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String text = textBox1.Text;
            String word = textBox2.Text;

            int count = 0;

            string[] mas = text.Split(' ');
            foreach (string s in mas)
            {
                if (s == word) count++;
            }

            textBox3.Text +=  count + " раза"; 

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
                MessageBox.Show("Введите слово, состоящее только из букв");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
        }
    }
}
