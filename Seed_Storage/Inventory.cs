using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seed_Storage
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();


        }

        public void GetBins()
        {
            using (Seed_Storage_DatasetTableAdapters.BinsTableAdapter BinsTableAdapter = new Seed_Storage_DatasetTableAdapters.BinsTableAdapter())
            {
                using (Seed_Storage_Dataset.BinsDataTable BinsDataTable = new Seed_Storage_Dataset.BinsDataTable())
                {
                    BinsTableAdapter.Fill(BinsDataTable);
                    int Cnt = 1;
                    foreach (Seed_Storage_Dataset.BinsRow row in BinsDataTable )
                    {
                        Panel panel = ((Panel)this.Controls[string.Format("panel{0}", Cnt)]);
                        Label  lblBin = ((Label)this.Controls[string.Format("lblBin{0}", Cnt)]);
                        Label lblCapacity = ((Label)this.Controls[string.Format("lblCapacity{0}", Cnt)]);
                        Label lblCurrent = ((Label)this.Controls[string.Format("lblCurrent{0}", Cnt)]);
                        Label progressBar = ((Label)this.Controls[string.Format("progressBar{0}", Cnt)]);

                        panel.Visible = true;


                        //this.lblCapacity1.Text = string.Format("Capacity: {0:N0}", Capacity);
                        //this.lblCurrent1.Text = string.Format("Current: {0:N0}", Current);
                        //double Percent = (Current / Capacity) * 100;
                        //if (Percent > 100) Percent = 100;
                        //if (Percent < 100) Percent = 0;
                        //this.progressBar1.Value = (int)Percent;


                    }

                }

            }

            
        }

        //public void SetValues(int Capacity, int Current ,Panel panel,Label lblBin,Label)
        //{
        //    this.lblCapacity1.Text = string.Format("Capacity: {0:N0}", Capacity);
        //    this.lblCurrent1.Text = string.Format("Current: {0:N0}", Current);
        //    double Percent = (Current / Capacity) * 100;
        //    if (Percent > 100) Percent = 100;
        //    if (Percent < 100) Percent = 0;
        //    this.progressBar1.Value = (int)Percent;

        //}
    }
}
