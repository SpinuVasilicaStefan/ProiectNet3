using Afisare_Poza;
using Functii;
using Proiect;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Afisare_Poza;
using Afisare_Video;
using System.IO;
using System.Diagnostics;

namespace Interfata
{
    public partial class Cautare : Form
    {
        string path = "";
        public Cautare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                Class1.Verificare_existenta();
                var lista = Class1.Initializare_proprietati();
                for (int i = 0; i < lista.Count; i++)
                {
                    listBox1.Items.Add((string)lista[i]);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null && textBox1.Text != "")
                {
                    listBox2.Items.Clear();
                    var lista = Class1.Afisare_rezultate((string)listBox1.SelectedItem, textBox1.Text);
                    if (lista.Count == 0)
                        MessageBox.Show("Nu exista nici o inregistrare pentru datele specificate",
                        "Sugestie",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    for (int i = 0; i < lista.Count; i++)
                            listBox2.Items.Add(lista[i]);


                }
                else
                    MessageBox.Show("Selectati o coloana si introduceti o valoare",
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItem != null)
                {
                    path = (string)listBox2.SelectedItem;
                    if (path.EndsWith(".mp4"))
                    {
                        var form = new Afisare_Video.AfisareVideo(path);
                        form.Show();
                    }
                    else
                    {
                        var form = new Afisare_Poza.AfisarePoza(path);
                        form.Show();
                    }
                }
                else
                    MessageBox.Show("Selectati o poza",
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.Items.Count != 0)
                {
                    string nume = "poze.txt";
                    SaveFileDialog sf = new SaveFileDialog();
                    sf.FileName = nume;
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = Path.GetDirectoryName(sf.FileName);

                        string scris = "";
                        foreach (var i in listBox2.Items)
                            scris = scris + (string)i + "\n";
                        Class1.Scriere_in_fisier(savePath + "\\" + nume, scris);
                        MessageBox.Show("Slavare efectuata cu succes");
                    }
                }
                else
                    MessageBox.Show("Cautati imagini",
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
    }
}
