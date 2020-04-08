using Proiect;
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
    public partial class StergereMedia : Form
    {
        public StergereMedia()
        {
            InitializeComponent();
        }

        private void StergereMedia_Load(object sender, EventArgs e)
        {
            try
            {
                using (Model1Container context = new Model1Container())
                {
                    FunctionsClient fc = new FunctionsClient();
                    var final = fc.Afisare_Media();
                    for (int i = 0; i < final.Count(); i++)
                    {
                        listBox1.Items.Add(final[i]);
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
                if (listBox1.SelectedItem != null)
                {
                    fc.stergere_poza((string)listBox1.SelectedItem);
                    MessageBox.Show("Imagine stearsa");
                    this.Close();
                }
                else
                    MessageBox.Show("Selectati o inregistrare",
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
