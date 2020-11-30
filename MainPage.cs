using CLIENTS_MANAGER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLIENTS_MANAGER.Extensions;

namespace CLIENTS_MANAGER
{
    public partial class MainPage : Form
    {
        private List<Client> clients;
        private ListViewItem clientItem;
        //index for the insertion of the client in the listview in the right line
        private int index;
        private DBclass dbHandler;

        public MainPage()
        {
            InitializeComponent();
            this.clients = new List<Client>();
            //instance of the DBhandler using singleton pattern
            dbHandler = DBclass.GetInstance();
            //loading DB
            LoadDB();
            //the index is initialized with the number of the clients in the list after the DB loading
            this.index = clients.Count;
            //when the application ends a method is called for saving the data in the DB
            Application.ApplicationExit += new EventHandler(FinalSaveData);
        }
        //method that creates and shows the NewClientPage for the creation of a new client
        private void bttnNewClient_Click(object sender, EventArgs e)
        {
            NewClientPage NewClientPageForm = new NewClientPage(clients);
            NewClientPageForm.ShowDialog();
            //if the number of customers in the list is equal to the index then it means that 
            //the insertion has been canceled, because the customers in the list have remained
            //unchanged, the number of customers in the list will be equal to the value of index.
            if (NewClientPageForm.clients.Count!=index)
            {
                clients = NewClientPageForm.clients;
                clientItem = new ListViewItem();
                clientItem = clients[index].ToListViewItem();
                lstVwMain.Items.Add(clientItem);
                index++;
            }
        }

        //method that create and show the ClientPage of the selected client
        private void bttnClientPage_Click(object sender, EventArgs e)
        {
            
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClientPage ClientPageForm = new ClientPage(clients[lstVwMain.SelectedIndices[0]]);
                ClientPageForm.ShowDialog();

            }
        }
        //method that creates and shows the EditClientPage to edit some fields of the selected client
        private void bttnEditClient_Click(object sender, EventArgs e)
        {
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int editIndex;
                EditClientPage EditClientPageForm = new EditClientPage(clients[lstVwMain.SelectedIndices[0]]);
                EditClientPageForm.ShowDialog();
                editIndex = lstVwMain.SelectedItems[0].Index;
                clients.RemoveAt(editIndex);
                lstVwMain.Items.RemoveAt(editIndex);
                clients.Insert(editIndex, EditClientPageForm.editedClient);
                lstVwMain.Items.Insert(editIndex, EditClientPageForm.editedClient.ToListViewItem());
            }
           
        }
        //method that remove the client
        private void bttnDelete_Click(object sender, EventArgs e)
        {
           
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Il cliente verrà rimosso, sei sicuro?", "Conferma", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    clients.Remove(clients[lstVwMain.SelectedIndices[0]]);
                    lstVwMain.Items.Remove(lstVwMain.SelectedItems[0]);
                    chrtWeight.Series[0].Points.Clear();
                    index--;
                }    
            }
        }
        //method that create the AddWeightPage and add a weight and a data in the list of the client
        private void bttnAddWeight_Click(object sender, EventArgs e)
        {
            if(lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                int editIndex;
                AddWeightPage AddWeightPageForm = new AddWeightPage(clients[lstVwMain.SelectedIndices[0]]);
                AddWeightPageForm.ShowDialog();
                editIndex = lstVwMain.SelectedItems[0].Index;
                clients.RemoveAt(editIndex);
                lstVwMain.Items.RemoveAt(editIndex);
                clients.Insert(editIndex, AddWeightPageForm.client);
                lstVwMain.Items.Insert(editIndex, AddWeightPageForm.client.ToListViewItem());
            }

        }
        //method that generate the graph when a client is selected
        private void lstVwMain_ItemActivate(object sender, EventArgs e)
        {
            var kgSeries = chrtWeight.Series[0];
            kgSeries.Points.Clear();
            var selectedClient = clients[lstVwMain.SelectedIndices[0]];
            chrtWeight.ChartAreas[0].AxisY.Minimum = (selectedClient.FindMinimumWeight()) - 1;
            for (int i = 0; i < selectedClient.DateList.Count; i++)
            {
                var date = selectedClient.DateList[i];
                var weight = selectedClient.WeightsList[i];
                kgSeries.Points.AddXY(date, weight);
            }
           
        }
        //method that reads the DB and inserts clients in to the listview
        private void LoadDB()
        {
            clients = dbHandler.GetData();
            for(int i = 0; i < clients.Count; i++)
            {
                clientItem = new ListViewItem();
                clientItem = clients[i].ToListViewItem();
                lstVwMain.Items.Add(clientItem);
            }
        }
        //method that save the data into the DB, called when the application end
        private void FinalSaveData(object sender, EventArgs e)
        {
            dbHandler.SaveData(clients);
        }

        
    }
}
