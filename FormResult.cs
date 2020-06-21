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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            Form2 form_2 = Owner as Form2;

            this.surname_.Text = form_2.surname2;
            this.name_.Text = form_2.name2;
            this.age_.Text = form_2.age2;

            if (form_2.gender2 == "М")
            {
                this.gender_.Text = "муж.";
            }
            else if (form_2.gender2 == "Ж")
            {
                this.gender_.Text = "жен.";
            }

            if (form_2.type2 == "Открытый")
            {
                this.type_.Text = "открытый";
            }
            else if (form_2.type2 == "Закрытый")
            {
                this.type_.Text = "закрытый";
            }

            if (form_2.metka == false)
            {
                this.predict_.Text = "не ожидаются.";
            }
            else if(form_2.metka == true)
            {
                this.predict_.Text = "ожидаются.";
                this.predict_.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }
}
