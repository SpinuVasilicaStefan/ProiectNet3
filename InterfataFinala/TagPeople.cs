using Proiect.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataFinala
{
    public partial class TagPeople : Form
    {
        public TagPeople()
        {
            InitializeComponent();
        }

        private void TagPeople_Load(object sender, EventArgs e)
        {
            try
            {
                FunctionsClient fc = new FunctionsClient();
                var final = fc.Afisare_persoane();
                for (int i = 0; i < final.Count(); i++)
                {
                    listBox2.Items.Add(final[i]);
                }
                var poze = fc.Afisare_Media();
                for (int i = 0; i < poze.Count(); i++)
                {
                    listBox1.Items.Add(poze[i]);
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
                if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
                {
                    Functii.Tag((string)listBox1.SelectedItem, (string)listBox2.SelectedItem);
                    MessageBox.Show("Tag adaugat");
                    this.Close();
                }
                else
                    MessageBox.Show("Selectati poza si persoana",
                    "Sugestie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                this.Close();
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
