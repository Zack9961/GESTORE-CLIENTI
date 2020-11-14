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
    public partial class ClientPage : Form
    {
        private Client clientStats;
        public ClientPage(Client c)
        {
            InitializeComponent();
            this.clientStats = c;
            this.txtName.Text = c.Name;
            this.txtSurname.Text = c.Surname;
            this.txtStartWeight.Text = c.WeightsList[0].ToString();
            this.txtFinalWeight.Text = c.LastWeight(c.WeightsList).ToString();
            this.txtHeight.Text = c.Height.ToString();
            this.txtAge.Text = c.Age.ToString();
            this.txtSex.Text = c.Sex;
            this.txtBMI.Text = c.BMICalculator().ToString();
            this.txtCategory.Text = c.CategoryCalculator();
           
            
        }



       

    }
}
