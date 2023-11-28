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

namespace List_listbox_islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            list.Add(ad);
            listBox1.Text = "🦅✨🎉🙂('◡')";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = list.ToList();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            string ad = txtAd.Text;
            list.Clear();
            listBox1.DataSource = list.ToList();
        }
    }
}
