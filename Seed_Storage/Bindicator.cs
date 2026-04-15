using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seed_Storage
{
    public partial class Bindicator : UserControl
    {
        public Bindicator(string Bin,int Capacity, int Current)
        {
            InitializeComponent();
            this.lblBin.Text = "Bin:" + Bin;
            SetValues(Capacity, Current);
        }

        public void SetValues( int Capacity, int Current)
        {
            this.lblCapacity.Text = string.Format("Capacity: {0:N0}", Capacity);
            this.lblCurrent.Text = string.Format("Current: {0:N0}", Current);
            double Percent = (Current / Capacity) * 100;
            if (Percent > 100) Percent = 100;
            if (Percent < 100) Percent = 0;
            this.progressBar1.Value = (int)Percent;

        }

    }
}
