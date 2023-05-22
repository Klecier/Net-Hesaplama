using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (matdgrutxt.Text == string.Empty)
            {
                MessageBox.Show("Matematik doğru sayısını giriniz");
            }
            else if (matynlstxt.Text == string.Empty)
            {
                MessageBox.Show("Matematik yanlış sayısını giriniz");
            }

            else if (fizikdgrutxt.Text == string.Empty)
            {
                MessageBox.Show("Fizik Doğru sayısını giriniz");
            }
            else if (fizikynlstxt.Text == string.Empty)
            {
                MessageBox.Show("Fizik yanlış sayısını giriniz");
            }

            else if (kimyadgrutxt.Text == string.Empty)
            {
                MessageBox.Show("Kimya doğru sayısını giriniz");
            }
            else if (kimyaynlstxt.Text == string.Empty)
            {
                MessageBox.Show("Kimya yanlış sayısını giriniz");

            }
            else if (edebdgrutxt.Text == string.Empty)
            {
                MessageBox.Show("Edebiyat doğru sayısını giriniz");
            }
            else if (edebynlstxt.Text == string.Empty)
            {
                MessageBox.Show("Edebiyat yanlış sayısını giriniz");
            }

            else
            {

                double matd = Convert.ToDouble(matdgrutxt.Text);
                double maty = Convert.ToDouble(matynlstxt.Text);
                double mnet = matd - (maty / 4);


                double fizd = Convert.ToInt32(fizikdgrutxt.Text);
                double fizy = Convert.ToInt32(fizikynlstxt.Text);
                double fnet = fizd - (fizy / 4);


                double kimd = Convert.ToInt32(kimyadgrutxt.Text);
                double kimy = Convert.ToInt32(kimyaynlstxt.Text);
                double knet = kimd - (kimy / 4);


                double eded = Convert.ToInt32(edebdgrutxt.Text);
                double edey = Convert.ToInt32(edebynlstxt.Text);
                double enet = eded - (edey / 4);
                edebiyatsnctxt.Text = enet.ToString();
                kimyasnctxt.Text = kimd.ToString();
                fiziksnctxt.Text = fnet.ToString();
                matsnctxt.Text = mnet.ToString();


                if (mnet < 10)
                { 
                    matsnctxt.BackColor = Color.LightCoral;
                    matsnctxt.Enabled = false;
                }
                else if (mnet > 10)
                {
                    matsnctxt.BackColor = Color.Silver;                
                    matsnctxt.Enabled = Enabled;
                }

                if (fnet < 10)
                {
                    fiziksnctxt.BackColor = Color.LightCoral;
                    fiziksnctxt.Enabled = false;
                }
                else if (fnet > 10)
                {
                    fiziksnctxt.BackColor= Color.Silver;
                    fiziksnctxt.Enabled= Enabled;
                }

                if (knet < 10)
                {
                    kimyasnctxt.BackColor = Color.LightCoral;
                    kimyasnctxt.Enabled = false;
                }
                else if (knet > 10)
                {
                    kimyasnctxt.BackColor = Color.Silver;
                    kimyasnctxt.Enabled = Enabled;
                }

                if (enet < 10)
                {
                    edebiyatsnctxt.BackColor = Color.LightCoral;
                    edebiyatsnctxt.Enabled = false;
                }
                else if (enet > 10)
                {
                    edebiyatsnctxt.BackColor = Color.Silver;
                    edebiyatsnctxt.Enabled = Enabled;
                }
                
            }

        }
    }
}
