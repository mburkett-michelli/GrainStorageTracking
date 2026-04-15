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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void varietiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.varietiesBindingSource.EndEdit();
      

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.commoditiesTableAdapter.Fill(this.seed_Storage_Dataset.Commodities);
            this.varietiesTableAdapter.Fill(this.seed_Storage_Dataset.Varieties);
            this.varietiesBindingSource.Filter = "Commodity='" + comboBox1.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int I= this.varietiesBindingSource.Find("Variety", this.textBox1.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.varietiesBindingSource.Filter = "Commodity='" + comboBox1.Text + "'";
        }
    }
}
