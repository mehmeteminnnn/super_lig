using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gspuan = 0;
        int fbpuan = 0;
        int tspuan = 0;
        int bjkpuan = 0;
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label5.Text = rastgele.Next(0, 5).ToString();
            label6.Text = rastgele.Next(0, 5).ToString();
            label7.Text = rastgele.Next(0, 5).ToString();
            label8.Text = rastgele.Next(0, 5).ToString();
            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label6.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label5.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) == Convert.ToInt32(label6.Text))
            {
                gspuan += 1;
                fbpuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();

            }//GS FB MAÇI BİTTİ
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label7.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label7.Text))
            {
                tspuan += 1;
                bjkpuan += 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label9.Text = rastgele.Next(0, 5).ToString();
            label10.Text = rastgele.Next(0, 5).ToString();
            label11.Text = rastgele.Next(0, 5).ToString();
            label12.Text = rastgele.Next(0, 5).ToString();
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label12.Text))
            {
                tspuan += 1;
                fbpuan += 1;
                labeltspuan.Text = tspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();

            }//TS FB MAÇI BİTTİ
            if (Convert.ToInt32(label10.Text) > Convert.ToInt32(label9.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label10.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) == Convert.ToInt32(label10.Text))
            {
                gspuan += 1;
                bjkpuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                MessageBox.Show("ŞAMPİYON CİMBOM");
            }
                if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text))
                {
                    MessageBox.Show  ("ŞAMPİYON FENER");
                }
                if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
                {
                    MessageBox.Show  ("ŞAMPİYON HAMSİ");
                }
                if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text))
                {
                    MessageBox.Show ("ŞAMPİYON TİNERCİ");
                }
            

            
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            label17.Text = rastgele.Next(0, 5).ToString();
            label18.Text = rastgele.Next(0, 5).ToString();
            label19.Text = rastgele.Next(0, 5).ToString();
            label20.Text = rastgele.Next(0, 5).ToString();
            if (Convert.ToInt32(label20.Text) > Convert.ToInt32(label19.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label19.Text) > Convert.ToInt32(label20.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label20.Text) == Convert.ToInt32(label19.Text))
            {
                gspuan += 1;
                tspuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();

            }//GS TS MAÇI BİTTİ
            if (Convert.ToInt32(label17.Text) > Convert.ToInt32(label18.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label17.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label17.Text) == Convert.ToInt32(label18.Text))
            {
                fbpuan += 1;
                bjkpuan += 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();

            }
        }
    }
    } 

