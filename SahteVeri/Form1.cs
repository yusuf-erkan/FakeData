using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SahteVeri
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<Ogrenci> olist = new List<Ogrenci>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FakeData o1 = new FakeData();
            FakeNumberData o2 = new FakeNumberData();

            for (int i = 1; i <= 100; i++)
            {
                Ogrenci o = new Ogrenci();

                o.id = i;
                o.isim =o1.Karmaisim();
                o.soyİsim = o1.Karmasoyisim();
                o.number = o2.Karmanumber();
                o.yas = o2.Karmayas();
                olist.Add(o);
               
            }
        }

        private void Doldur()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;

            
        }

    }
}
