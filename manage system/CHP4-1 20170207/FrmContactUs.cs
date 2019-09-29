using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHP4_1_20170207
{
    public partial class FrmContactUs : Form
    {
        public FrmContactUs()
        {
            InitializeComponent();
        }
        int index = 0;
        private void tContactUs_Tick(object sender, EventArgs e)
        {
            if (index<ilContactUs.Images.Count-1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            pbContactUs.Image=ilContactUs.Images[index];

        }


    }
}
