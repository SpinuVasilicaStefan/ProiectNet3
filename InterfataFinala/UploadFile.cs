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
    public partial class UploadFile : Form
    {
        
        string path = "";
        public UploadFile()
        {
            InitializeComponent();
        }

        private void UploadFile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opnfd = new OpenFileDialog();
                opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.mp4;)|*.jpg;*.jpeg;.*.gif;*.mp4";
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    path = opnfd.FileName;
                    label5.Text = "Uploaded";
                }
                MessageBox.Show("File uploaded");
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
            FunctionsClient fc = new FunctionsClient();
            if (path != "")
            {
                fc.Add_Media(textBox1.Text, textBox2.Text, path, textBox3.Text, textBox4.Text);
                MessageBox.Show("Fisier adaugat");
                this.Close();
            }
            else
                MessageBox.Show("Incarcati o imagine",
                "Sugestie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }
    }
}
