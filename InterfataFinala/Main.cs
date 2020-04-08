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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new UploadFile();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AdaugareProprietate();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new EditareProprietati();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Cautare();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new StergereMedia();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new TagPeople();
            form.Show();
        }
    }
}
