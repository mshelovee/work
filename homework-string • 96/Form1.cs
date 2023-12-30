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
using static System.Net.Mime.MediaTypeNames;

namespace homework_string___96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEndswith_Click(object sender, EventArgs e)
        {
            string mesaj = "Hilal!";
            bool sonuc = mesaj.EndsWith(mesaj);

            MessageBox.Show("Sonuç :" + sonuc);
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba, Ben Hilal!";
            int ben = mesaj.IndexOf("Ben");

            int index = 0;
            int indexSira = ben;

            MessageBox.Show("Aranan kelimenin index sırası: " + indexSira);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            string str = "Hilal";
            int sonKarakter = str.LastIndexOf("i");

            if (sonKarakter != -1)
            {
                MessageBox.Show(sonKarakter.ToString());
            }
        }

        private void btnStarts_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba, Ben Hilal!";
            MessageBox.Show("H ile mi başlıyyor: " + mesaj.StartsWith("H"));
        }
    }
}
