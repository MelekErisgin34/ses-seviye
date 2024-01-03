using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ses_Seviye_Kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbBarSes_Scroll(object sender, EventArgs e)
        {
            int deger = tBarSes.Value;
            lblSeviyedeger.Text = deger.ToString();


            if (deger >= 0 && deger < 25)
            {
                lblSesseviyesi1.Text = "Ses Seviyesi Düşük";
                this.BackColor = Color.CadetBlue;
            }
            else if (deger >= 25 && deger < 70)
            {
                lblSesseviyesi1.Text = "Ses Seviyesi Normal";
                this.BackColor = Color.Purple;
            }
            else if (deger >= 70 && deger < 90)
            {
                lblSesseviyesi1.Text = "Ses Seviyesi Yüksek";
                this.BackColor = Color.Orange;
            }
            else
            {
                lblSesseviyesi1.Text = "Ses Seviyesi Çok Yüksek";
                this.BackColor = Color.Red;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSesseviyesi1.Text = "Ses Seviyesi Düşük";
            this.BackColor = Color.CadetBlue;
            lblSeviyedeger.Text = "0";
        }
    }
}
            
    
