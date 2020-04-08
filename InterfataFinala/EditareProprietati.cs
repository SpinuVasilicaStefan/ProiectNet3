using Proiect.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataFinala
{
    public partial class EditareProprietati : Form
    {
        public EditareProprietati()
        {
            InitializeComponent();
        }

        private void EditareProprietati_Load(object sender, EventArgs e)
        {
            try
            {
                FunctionsClient fc = new FunctionsClient();
                var final = fc.Initializare_proprietati();
                for (int i = 0; i < final.Count(); i++)
                {
                    listBox2.Items.Add(final[i]);
                }
                var poze = fc.Afisare_Media();
                for (int i = 0; i < poze.Count(); i++)
                {
                    if (File.Exists(poze[i]))
                        listBox1.Items.Add(poze[i]);
                    else
                    {
                        listBox1.Items.Add(poze[i]);
                        listBox3.Items.Add(poze[i]);
                    }

                }
            }
            catch
            {
                MessageBox.Show("There was an error",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionsClient fc = new FunctionsClient();
                if (listBox1.SelectedItem != null && listBox2.SelectedItem != null && textBox1.Text != "")
                {
                    fc.Update_proprietati((string)listBox1.SelectedItem, (string)listBox2.SelectedItem, textBox1.Text);
                    MessageBox.Show("Editare efectuata cu succes");
                    this.Close();
                }
                else
                    MessageBox.Show("Selectati o poza, o coloana si introduceti o valoare",
                    "Sugestie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("There was an error",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
