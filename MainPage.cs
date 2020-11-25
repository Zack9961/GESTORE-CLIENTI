using GESTORE_CLIENTI;
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
        private List<Client> clients;
        private ListViewItem clientItem;
        private int index;
        private DBhandler dbHandler;

        public MainPage()
        {
            InitializeComponent();
            this.clients = new List<Client>();
            dbHandler = new DBhandler();
            LoadDB();
            this.index = this.clients.Count;
        }

        private void bttnNewClient_Click(object sender, EventArgs e)
        {

            NewClientPage NewClientPageForm = new NewClientPage(clients);
            NewClientPageForm.ShowDialog();
            //se il numero di clienti nella lista è uguale all'indice allora vuol dire
            //che è stato annullato l'inserimento, dato che i clienti nella lista sono rimasti
            //invariati, il numero di clienti nella lista sarà uguale al valore di index;
            if(NewClientPageForm.clients.Count!=index)
            {
                clients = NewClientPageForm.clients;
                clientItem = new ListViewItem();
                clientItem = clients[index].ToListViewItem(clients[index]);
                dbHandler.SaveData(clients);
                lstVwMain.Items.Add(clientItem);
                index++;
            }
            

        }


        private void bttnClientPage_Click(object sender, EventArgs e)
        {
            
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClientPage ClientPageForm = new ClientPage(clients[lstVwMain.SelectedIndices[0]]);
                ClientPageForm.ShowDialog();

            }
        }

        

        private void bttnEditClient_Click(object sender, EventArgs e)
        {
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                lstVwMain.Items.Insert(editIndex, EditClientPageForm.editedClient.ToListViewItem(EditClientPageForm.editedClient));
                dbHandler.SaveData(clients);

            }
            
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clients.Remove(clients[lstVwMain.SelectedIndices[0]]);
                lstVwMain.Items.Remove(lstVwMain.SelectedItems[0]);
                chrtWeight.Series[0].Points.Clear();
                dbHandler.SaveData(clients);
                index--;
            }
        }

        private void bttnAddWeight_Click(object sender, EventArgs e)
        {
            if(lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                int editIndex;
                AddWeightPage AddWeightPageForm = new AddWeightPage(clients[lstVwMain.SelectedIndices[0]]);
                AddWeightPageForm.ShowDialog();
                editIndex = lstVwMain.SelectedItems[0].Index;
                clients.RemoveAt(editIndex);
                lstVwMain.Items.RemoveAt(editIndex);
                clients.Insert(editIndex, AddWeightPageForm.client);
                lstVwMain.Items.Insert(editIndex, AddWeightPageForm.client.ToListViewItem(AddWeightPageForm.client));
                dbHandler.SaveData(clients);
            }

        }

        
        
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


        /*private void updateClient(int index, Client client)
        {
            this.clients.RemoveAt(index);
            lstVwMain.Items.RemoveAt(index);
            this.clients.Insert(index, client);
            lstVwMain.Items.Insert(index, client.ToListViewItem(client));
        }*/

        private void LoadDB()
        {
            clients = dbHandler.GetData();
            for(int i = 0; i < clients.Count; i++)
            {
                clientItem = new ListViewItem();
                clientItem = clients[i].ToListViewItem(clients[i]);
                lstVwMain.Items.Add(clientItem);
            }
        }

        
    }
}
