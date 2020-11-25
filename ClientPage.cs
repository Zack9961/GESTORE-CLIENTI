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
    public partial class ClientPage : Form
    {
        private Client clientStats;
        public ClientPage(Client c)
        {
            InitializeComponent();
            this.clientStats = c;
            this.txtName.Text = c.Name;
            this.txtSurname.Text = c.Surname;
            this.txtFirstWeight.Text = c.WeightsList[0].ToString();
            this.txtLastWeight.Text = c.LastWeight(c.WeightsList).ToString();
            this.txtHeight.Text = c.Height.ToString();
            this.txtAge.Text = c.Age.ToString();
            this.txtSex.Text = c.Sex;
            this.txtBMI.Text = c.BMICalculator().ToString();
            this.txtCategory.Text = c.CategoryCalculator();
            this.dtpFirstWeight.Value = c.DateList[0];
            this.dtpLastWeight.Value = c.LastDate(c.DateList);
            this.txtIdealWeight.Text = IdealWeightCalculator().ToString();
            this.txtWeightChanged.Text = WeightChangedCalculator().ToString();
            this.txtWeightChangedWeekly.Text = WeightChangedWeeklyClaculator().ToString();
           
            
        }

        private float IdealWeightCalculator()
        {
            double idealWeight;
            if(clientStats.Sex == "Maschio")
            {
                idealWeight = (clientStats.Height) * (clientStats.Height) * 22.1;
            }
            else
            {
                idealWeight = (clientStats.Height) * (clientStats.Height) * 20.6;
            }

            return (float)(Math.Round(idealWeight,1));
        }

        private float WeightChangedCalculator()
        {
            double lastWeight;
            double firstWeight;
            double weightChanged;
            lastWeight = clientStats.LastWeight(clientStats.WeightsList);
            firstWeight = clientStats.WeightsList[0];
            weightChanged = lastWeight - firstWeight;
            return (float)Math.Round(weightChanged, 1);
        }

        private float WeightChangedWeeklyClaculator()
        {
            DateTime lastDate = clientStats.LastDate(clientStats.DateList);
            DateTime firstDate = clientStats.DateList[0];
            double weightChanged = (WeightChangedCalculator());
            TimeSpan timeSpan = lastDate - firstDate;
            double weeks = timeSpan.Days / 7.00;
            double weightChangedWeekly = weightChanged / weeks;
            return (float)(Math.Round(weightChangedWeekly, 2));

        }

       

    }
}
