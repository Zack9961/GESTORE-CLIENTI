using PrototipoProgetto;
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
    public partial class NewClientPage : Form
    {
        private String name;
        private String surname;
        private String sex;
        private String weight;
        private String height;
        private Client client;
        private ListViewItem clientItem;
        private ListViewItem.ListViewSubItem clientSubItem;

        public NewClientPage(ListViewItem c,ListViewItem.ListViewSubItem s)
        {
            InitializeComponent();
            this.clientItem = c;
            this.clientSubItem = s;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            this.clientItem.Text = txtName.Text;
            this.clientSubItem.Text = txtSurname.Text;
            if(rdBttnSexFemale.Checked)
            {
                sex = "Female";
            }
            else
            {
                sex = "Male";
            }
            //this.clientSubItem.Text = txtWeight.Text;
            height = txtHeight.Text;
            
            Close();
            //MessageBox.Show(this.client.name);

            

        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.clientItem = null;
            Close();
        }

        public ListViewItem getClient()
        {
            return this.clientItem;
        }
    }
}
