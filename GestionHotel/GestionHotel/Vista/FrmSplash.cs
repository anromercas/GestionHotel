using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionHotel
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 5000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
