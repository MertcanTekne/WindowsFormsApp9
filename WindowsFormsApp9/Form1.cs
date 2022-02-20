using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string pass = textBox3.Text;
            string pass2 = textBox2.Text;
            if (pass == pass2)
            {
                linkLabel1.Text = "Doğru";

            }
            else
            {
                linkLabel1.Text = "YANLIŞ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox4.Text;
            string pass = textBox3.Text;
            string kadin = radioButton1.Text;
            
            string cinsiyet = "";
            if (checkBox1.Checked)
            {
                MessageBox.Show("aşağıdaki bilgiler" +" "+ ad + " " + soyad + " " + pass+" "+cinsiyet);
                if (kadin == "true")
                {
                    cinsiyet = "kadin";
                }
                else
                {
                    cinsiyet = "erkek";
                }
            }
            else
            {
                MessageBox.Show("onaylamadınız");
            }
        }
    }
}
