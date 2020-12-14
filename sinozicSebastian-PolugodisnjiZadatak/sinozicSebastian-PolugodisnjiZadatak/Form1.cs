using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinozicSebastian_PolugodisnjiZadatak
{
    
    public partial class Form1 : Form
    {
        List<Automobil> Automobil = new List<Automobil>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string godiste1 = textBox3.Text;

            if (string.IsNullOrWhiteSpace(marka) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(godiste1)) 
            {
                MessageBox.Show("Podaci su krivo uneseni!");
                return;
            }
            int godiste = Convert.ToInt32(godiste1);
            Automobil.Add(new Automobil(marka, model, godiste));
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        //button3
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Naziv         Model          Godiste          Status");
            foreach (Automobil automobil in Automobil)
            {
                listBox1.Items.Add(automobil.ToString());
            }
        }
        //button2
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Automobil.Count; i++)
            {
                if (Automobil[i].Godiste == 2020)
                {
                    Automobil[i].Status = "Novo";
                }
                else if (Automobil[i].Godiste <= 1990)
                {
                    Automobil[i].Status = "Oldtimer";
                }
                else
                {
                    Automobil[i].Status = "Skoro novo";
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

