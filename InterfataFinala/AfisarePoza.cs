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
    public partial class AfisarePoza : Form
    {
        public string salut;
        public AfisarePoza()
        {
            InitializeComponent();
        }

        public AfisarePoza(string path)

        {
            salut = path;
            InitializeComponent();
        }

        private void AfisarePoza_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(salut);
                pictureBox1.ImageLocation = salut;
                pictureBox1.Size = new Size(img.Height, img.Width);
                this.Width = img.Width;
                this.Height = img.Height;
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
