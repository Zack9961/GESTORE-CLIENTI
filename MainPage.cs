using Prova2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProgetto
{
    public partial class MainPage : Form
    {
        //private Client client;

        public MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem clientItem = new ListViewItem();
            ListViewItem.ListViewSubItem clientSubItem = new ListViewItem.ListViewSubItem();
            //Client client = new Client(null,"ciao","ciao","ciao","ciao");
            Form NewClientPageForm = new NewClientPage(clientItem,clientSubItem);
            NewClientPageForm.ShowDialog();
            if(clientItem!=null)
            {
                lstVwMain.Items.Add(clientItem);
                clientItem.SubItems.Add(clientSubItem);
            }
            else
            {
                lstVwMain.Items.Remove(clientItem);
            }
            




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ClientPageForm = new ClientPage();
            ClientPageForm.ShowDialog();
        }

        private void lblClientPage_Click(object sender, EventArgs e)
        {

        }

        private void bttnEditClient_Click(object sender, EventArgs e)
        {
            if(lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente");
            }else
            {

                lstVwMain.SelectedIndices.Clear();
                ListViewItem newClientItem = new ListViewItem();
                ListViewItem.ListViewSubItem newClientSubItem = new ListViewItem.ListViewSubItem();
                Form EditClientPageForm = new EditClientPage(newClientItem, newClientSubItem);
                EditClientPageForm.ShowDialog();
                

            }
            
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
