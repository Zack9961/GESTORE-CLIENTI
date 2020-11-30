using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTS_MANAGER.Extensions
{
    public static class ClientExtensions
    {
        public static ListViewItem ToListViewItem(this Client client)
        {
            string[] row = { client.Name, client.Surname, client.LastWeight(client.WeightsList).ToString()+" kg",
                client.Height.ToString()+" m", client.Sex, client.Age.ToString()+" anni" };
            return new ListViewItem(row);
        }


    }
}
