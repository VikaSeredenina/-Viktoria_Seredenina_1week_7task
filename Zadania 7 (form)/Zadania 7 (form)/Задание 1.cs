using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadania_7__form_
{
    public partial class Задание_1 : Form
    {
        public Задание_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string a = textBox1.Text;
            string x = textBox2.Text;
    

            string res = a.Replace(x, string.Empty);
            textBox3.Text +=  res;
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
