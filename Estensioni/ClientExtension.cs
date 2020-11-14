using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Prova2.Estensioni
{
    public static class ClientExtension
    {
        public static ListViewItem ToListViewItem(/*this*/ Client client)
        {
            string[] row = { client.Name, client.Surname, client.Weight.ToString(), client.Height.ToString(), client.Sex, client.Age.ToString() };
            return new ListViewItem(row);
        }

        public static Client ToItem(this ListViewItem client)
        {
            return new Client(client.SubItems[0].Text, client.SubItems[1].Text,
                float.Parse(client.SubItems[2].Text), float.Parse(client.SubItems[3].Text),
                client.SubItems[5].Text, int.Parse(client.SubItems[4].Text));
            
        }










    }
}
