using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2
{
    public partial class AddWeightPage : Form
    {
        public Client client { get; set; }
        public AddWeightPage(Client c)
        {
            InitializeComponent();
            this.client = c;
            this.dtpWeightData.MinDate = c.LastDate(c.DateList);
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            
            client.WeightsList.Add(float.Parse(txtWeight.Text));
            client.DateList.Add(dtpWeightData.Value);
            Close();
        }

    } 
}
