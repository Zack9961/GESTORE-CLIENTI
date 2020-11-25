﻿using PrototipoProgetto;
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
    public partial class NewClientPage : Form
    {
        
        public List<Client> clients { get; set; }
        private String sex;

        public NewClientPage(List<Client> clients)
        {
            InitializeComponent();
            this.clients = clients;
            this.sex = null;
  
        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            
            if (CheckFields())
            {
                CheckRadioBttn();
                AddClient();
                Close();
            }
            else
            {
                MessageBox.Show("Riempi tutti i campi!");
            }
           
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void AddClient()
        {
            var client = new Client(txtName.Text, txtSurname.Text, float.Parse(txtWeight.Text),
                float.Parse(txtHeight.Text), sex, dtpBirthday.Value);
                clients.Add(client);
            client.DateList.Add(DateTime.Now);
        }

        private bool CheckFields()
        {
            return !string.IsNullOrEmpty(txtName.Text)
                && !string.IsNullOrEmpty(txtSurname.Text)
                && !string.IsNullOrEmpty(txtWeight.Text)
                && !string.IsNullOrEmpty(txtHeight.Text)
                && (rBttnFemale.Checked 
                ||  rBttnMale.Checked);       
        }

        private void CheckRadioBttn()
        {
            if (rBttnFemale.Checked)
            {
                sex = "Femmina";
            }
            else
            {
                sex = "Maschio";
            }

        }

        internal void HandleInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }




    }
}
