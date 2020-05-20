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
    public partial class Cautare : Form
    {
        string path = "";
        public Cautare()
        {
            InitializeComponent();
        }

        private void Cautare_Load(object sender, EventArgs e)
        {
            try
            {
                FunctionsClient fc = new FunctionsClient();
                fc.Verificare_existenta();
                var lista = fc.Initializare_proprietati();
                for (int i = 0; i < lista.Count(); i++)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionsClient fc = new FunctionsClient();
                if (listBox1.SelectedItem != null && textBox1.Text != "")
                {
                    listBox2.Items.Clear();
                    var lista = fc.Afisare_rezultate((string)listBox1.SelectedItem, textBox1.Text);
                    if (lista.Count() == 0)
                        MessageBox.Show("Nu exista nici o inregistrare pentru datele specificate",
                        "Sugestie",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    for (int i = 0; i < lista.Count(); i++)
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
                        
                    }
                    else
                    {
                        var form = new AfisarePoza(path);
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

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (listBox2.Items.Count != 0)
                {
                    FunctionsClient fc = new FunctionsClient();
                    string nume = "poze.txt";
                    SaveFileDialog sf = new SaveFileDialog();
                    sf.FileName = nume;
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = Path.GetDirectoryName(sf.FileName);

                        string scris = "";
                        foreach (var i in listBox2.Items)
                            scris = scris + (string)i + "\n";
                        fc.Scriere_in_fisier(savePath + "\\" + nume, scris);
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
