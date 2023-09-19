using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1.exe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNama.Text = "Rangga Saputra";
            lblKelas.Text = "Informatika 04";
            lblNim.Text = "22.11.4787";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNama.Text = "";
            lblKelas.Text = "";
            lblNim.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
