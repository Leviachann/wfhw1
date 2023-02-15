using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CityTime : Form
    {
        public CityTime()
        {
            InitializeComponent();
            Datecurrent.Text = DateTime.Now.ToString("HH:mm");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBaku_Click(object sender, EventArgs e)
        {
            cityPic.Image = Properties.Resources.london;
            Datecurrent.Text = DateTime.Now.ToString("HH:mm");
        }

        private void BtnLondon_Click(object sender, EventArgs e)
        {
            cityPic.Image = Properties.Resources.london;
            Datecurrent.Text = DateTime.UtcNow.ToString("HH:mm");
        }
    }
}
