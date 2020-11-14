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
        public List<Client> clients;
        public ListViewItem clientItem;
        private int index;

        public MainPage()
        {
            InitializeComponent();
            this.clients = new List<Client>();
            this.index = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NewClientPage NewClientPageForm = new NewClientPage(clients);
            NewClientPageForm.ShowDialog();
            //se il numero di clienti nella lista è uagule all'indice allora vuol dire
            //che è stato annullato l'inserimento, 0 clienti nella lista e index == 0;
            if(NewClientPageForm.clients.Count!=index)
            {
                clients = NewClientPageForm.clients;
                clientItem = new ListViewItem();
                clientItem = clients[index].ToListViewItem(clients[index]);
                lstVwMain.Items.Add(clientItem);
                index++;
            }
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente");
            }
            else
            {
                ClientPage ClientPageForm = new ClientPage(clients[lstVwMain.SelectedIndices[0]]);
                ClientPageForm.ShowDialog();


            }
        }

        private void lblClientPage_Click(object sender, EventArgs e)
        {


        }

        private void bttnEditClient_Click(object sender, EventArgs e)
        {
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente");
            }
            else
            {
                int editIndex;
                EditClientPage EditClientPageForm = new EditClientPage(clients[lstVwMain.SelectedIndices[0]]);
                EditClientPageForm.ShowDialog();
                editIndex = lstVwMain.SelectedItems[0].Index;
                this.clients.RemoveAt(editIndex);
                lstVwMain.Items.RemoveAt(editIndex);
                this.clients.Insert(editIndex, EditClientPageForm.editedClient);
                lstVwMain.Items.Insert(editIndex, EditClientPageForm.editedClient.ToListViewItem(EditClientPageForm.editedClient));
                
                
            }
            
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente");
            }
            else
            {
                this.clients.Remove(clients[lstVwMain.SelectedIndices[0]]);
                lstVwMain.Items.Remove(this.lstVwMain.SelectedItems[0]);
                index--;
            }
        }

        private void bttnAddWeight_Click(object sender, EventArgs e)
        {
            if(lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente");
            }else
            {
                int editIndex;
                AddWeightPage AddWeightPageForm = new AddWeightPage(clients[lstVwMain.SelectedIndices[0]]);
                AddWeightPageForm.ShowDialog();
                editIndex = lstVwMain.SelectedItems[0].Index;
                this.clients.RemoveAt(editIndex);
                lstVwMain.Items.RemoveAt(editIndex);
                this.clients.Insert(editIndex, AddWeightPageForm.client);
                lstVwMain.Items.Insert(editIndex, AddWeightPageForm.client.ToListViewItem(AddWeightPageForm.client));

            }
        }

        /*private void updateClient(int index, Client client)
        {
            this.clients.RemoveAt(index);
            lstVwMain.Items.RemoveAt(index);
            this.clients.Insert(index, client);
            lstVwMain.Items.Insert(index, client.ToListViewItem(client));
        }*/

    }
}
