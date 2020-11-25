using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTORE_CLIENTI
{
    public partial class EditClientPage : Form
    {
        public Client editedClient { get; set; }
        public EditClientPage(Client c)
        {
            InitializeComponent();
            this.editedClient = c;
            this.txtName.Text = c.Name;
            this.txtSurname.Text = c.Surname;
            this.txtWeight.Text = c.WeightsList[0].ToString();
            this.txtHeight.Text = c.Height.ToString();
            this.dtpBirthday.Value = c.BirthdayData;
            if (c.Sex == "Maschio")
            {
                this.rBttnMale.Checked = true;
            }
            else
            {
                this.rBttnFemale.Checked = true;
            }
     
        }

        
        private void bttnOk_Click(object sender, EventArgs e)
        {
            this.editedClient.Name = txtName.Text;
            this.editedClient.Surname = txtSurname.Text;
            this.editedClient.Height = float.Parse(txtHeight.Text);
            this.editedClient.WeightsList.RemoveAt(0);
            this.editedClient.WeightsList.Insert(0, float.Parse(txtWeight.Text));
            this.editedClient.BirthdayData = dtpBirthday.Value;
            this.editedClient.Age = this.editedClient.AgeCalculator(dtpBirthday.Value);
            if (rBttnFemale.Checked)
            {
                this.editedClient.Sex = "Femmina";
            }
            else
            {
                this.editedClient.Sex = "Maschio";
            }
            
            Close();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void HandleInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }

    }
}
