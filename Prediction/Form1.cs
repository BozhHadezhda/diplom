using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prediction
{
    public partial class Form1 : Form
    {
        public string name1,surname1, age1, gender1;

        private void age1__KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
              if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void surname1__KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) == true)
                return;
                e.Handled = true;
            return;
        }

        private void name1__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) == true)
                return;
            e.Handled = true;
            return;
        }

        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            if (name1_.Text == "" | surname1_.Text == "" | age1_.Text == "" | gender_.Text =="")
            {
                MessageBox.Show("Проверти  все поля ");
                return;
            }
            else
            {
                name1 = this.name1_.Text;
                surname1 = this.surname1_.Text;
                age1 = this.age1_.Text;
                gender1 = this.gender_.Text;
                this.Hide();
                new Form2().Show(this);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
