using Proiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var form = new Adaugare_Media.Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Adaugare_Proprietate_Dinamica.AdaugareDinamica();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Editare_Proprietati.EditareProprietati();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Interfata.Cautare();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new Stergere_media.Form1();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new Tag_People.Form1();
            form.Show();
        }
    }
}
