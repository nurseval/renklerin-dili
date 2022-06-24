using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renklerindili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Yönetici" && textBox2.Text == "369963")
            {
                Form2 renkformu = new Form2();
                renkformu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş Yaptınız Lütfen Yeniden Deneyiniz!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
