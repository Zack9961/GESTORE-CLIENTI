using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTS_MANAGER
{
    public partial class AddWeightPage : Form
    {
      
        public Client client { get; set; }
        public AddWeightPage(Client c)
        {
            InitializeComponent();
            this.client = c;
            //this command sets the minimum selectable date to the last date of the dates list
            //doing this we can't select a data in the past and the lists, of weights and dates, are ordered
            this.dtpWeightData.MinDate = c.LastDate(c.DateList);
            
        }
        //method that close the window
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //method that adds new weight to the client's list of weights
        private void bttnOk_Click(object sender, EventArgs e)
        {
            client.WeightsList.Add(float.Parse(txtWeight.Text));
            client.DateList.Add(dtpWeightData.Value);
            Close();
        }
        //method that blocks wrong input
        internal void HandleInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }

    } 
}
