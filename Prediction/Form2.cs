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
    public partial class Form2 : Form
    {
        public int  experience, PIVSA,   XCMH;
        public string NYHA, CBCA, XOBL, PCKBCA, KBOCA, CCBCA, ONMK;
        public bool metka;
        

        public string name2, surname2, age2, type2, gender2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          //  this.textBox1.Text = (Form1)Owner.name_.Text;

         
            Form1 form_1 = Owner as Form1;
            this.name2 = form_1.name1;
            this.surname2 = form_1.surname1;
            this.age2 = form_1.age1;
            this.gender2 = form_1.gender1;

            //textBox1.Text = form.name;
        }

        private void result_Click(object sender, EventArgs e)
        {

            if (type_.Text == "" | CBCA_.Text == "" | NYHA_.Text == "" | experience_.Text == "" | PCKBCA_.Text == "" | PIVSA_.Text == "" | KBOCA_.Text == "" | CCBCA_.Text == "" | XOBL_.Text == "" | ONMK_.Text == "" | XCMH_.Text == "")
            {
                MessageBox.Show("Проверти все ли поля заполнены");
                return;
            }
            else
            {
                
                this.type2 = this.type_.Text;

                this.XCMH = Convert.ToInt32(this.XCMH_.Text);
                this.CBCA = this.CBCA_.Text;
                this.NYHA = this.NYHA_.Text;
                this.experience = Convert.ToInt32(this.experience_.Text);
                this.PCKBCA = this.PCKBCA_.Text;
                this.PIVSA = Convert.ToInt32(this.PIVSA_.Text);
                this.KBOCA = this.KBOCA_.Text;
                this.CCBCA = this.CCBCA_.Text;
                this.XOBL = this.XOBL_.Text;
                this.ONMK = this.ONMK_.Text;


                //========================================================================================================================================
                //                                        Открытый
                //========================================================================================================================================

                if (this.type_.SelectedItem.ToString() == "Открытый")
                {
                    if (experience <= 4.2959)
                    {
                        if (experience >= 3.7391)
                        {
                            if (XCMH <= 3.3008)
                            {
                                if ((XOBL != "0") || (XOBL != "1") || (XOBL != "2"))
                                {
                                    if ((CBCA == "50-69") || (CBCA == "90-99"))
                                    {
                                        metka = true;
                                    }
                                    else metka = false;
                                }
                                else metka = true;

                            }
                            else
                            {
                                if (CBCA == "70-89")
                                {
                                    if (XOBL == "0")
                                    {
                                        if ((NYHA == " 1") || (NYHA == " 2") || (NYHA == " 3") || (NYHA == " 4"))
                                        {
                                            metka = true;
                                        }
                                        else metka = false;
                                    }
                                    else metka = false;

                                }
                                else if (NYHA == "3")
                                {
                                    metka = true;
                                }
                                else metka = false;
                            }
                        }
                        else metka = true;

                    }
                    else if ((ONMK == "0") || (ONMK == "1"))
                    {
                        if ((KBOCA == "0") || (KBOCA == "2"))
                        {
                            if (PCKBCA != "с/п ТБА")
                            {
                                if ((CBCA != "50-69") || (CBCA != "70-89"))
                                {
                                    if (CCBCA != "0")
                                    {
                                        if ((XOBL == "1") || (XOBL == "2") || (XOBL == "3"))
                                        {
                                            metka = true;
                                        }
                                        else metka = false;
                                    }
                                    else metka = true;
                                }
                                else metka = true;
                            }
                            else metka = true;
                        }
                        else if (XCMH <= 2.2727)
                        {
                            metka = true;
                        }
                        else metka = false;
                    }
                    else if ((PCKBCA != "100") || (PCKBCA != "90-99"))
                    {
                        if (NYHA == "1")
                        {
                            metka = true;
                        }
                        else metka = false;
                    }
                    else metka = true;


                }

                //========================================================================================================================================
                //                                           Закрытый
                //========================================================================================================================================
                else if (this.type_.SelectedItem.ToString() == "Закрытый")
                {
                    if (experience <= 3.5)
                    {
                        if (XCMH <= 2.5)
                        {
                            metka = true;
                        }
                        else metka = false;
                    }
                    else if ((ONMK != "0") || (ONMK != "1"))
                    {
                        if ((PCKBCA == "с/п ТБА") || (PCKBCA == "0-49") || (PCKBCA == "50-69"))
                        {
                            if ((NYHA != "0") || (NYHA != "1"))
                            {
                                if (PCKBCA == "0-49")
                                {
                                    if (XOBL == "0")
                                    {
                                        metka = true;
                                    }
                                    else metka = false;
                                }
                                else metka = false;
                            }
                            else metka = true;
                        }
                        else metka = false;
                    }
                    else if (XOBL == "0")
                    {
                        if (experience <= 4.5)
                        {
                            if (CBCA == "90-99")
                            {
                                if (PCKBCA == "0-49")
                                {
                                    if (XCMH >= 3.5)
                                    {
                                        if (NYHA == "2")
                                        {
                                            if (KBOCA == "0")
                                            {
                                                metka = true;
                                            }
                                            else metka = false;
                                        }
                                        else metka = false;
                                    }
                                    else metka = true;
                                }
                                else metka = false;
                            }
                            else metka = false;
                        }
                        else metka = false;
                    }
                    else if ((NYHA != "0") || (NYHA != "1") || (NYHA != "2"))
                    {
                        if ((PCKBCA == "0-49") || (PCKBCA == "50-69"))
                        {
                            if (XCMH >= 2.5)
                            {
                                if ((KBOCA == "0") || (KBOCA == "1"))
                                {
                                    if (PCKBCA == "0-49")
                                    {
                                        metka = true;
                                    }
                                    else metka = false;
                                }
                                else metka = false;
                            }
                            else metka = true;
                        }
                        else metka = false;
                    }
                    else if (PCKBCA == "с/п ТБА")
                    {
                        if ((XOBL == "1") || (XOBL == "2"))
                        {
                            metka = true;
                        }
                        else metka = false;
                    }
                    else metka = false;


                }
                    this.Hide();
                    new FormResult().Show(this);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
