using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTS_MANAGER
{
    public class Client
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Sex { get; set; }
        public float Height{ get; set; }
        public DateTime BirthdayData { get; set; }
        public int Age { get; set; }
        public List<float> WeightsList { get; set; }
        public List<DateTime> DateList { get; set; }
        public float BMI { get; set; }
        public String Category { get; set; }
        //setting fields
        public Client(String name,String surname,float weight,float height,String sex, DateTime bData)
        {
            this.Name = name;
            this.Surname = surname;
            this.Height = height;
            this.Sex = sex;
            this.BirthdayData = bData;
            this.WeightsList = new List<float>();
            this.WeightsList.Add(weight);
            this.DateList = new List<DateTime>();
            this.Age = AgeCalculator(bData);
            this.BMI = BMICalculator();
            this.Category = CategoryCalculator();
        }
        //method that calculates the age of the client
        public int AgeCalculator(DateTime bData)
        {
            DateTime from = bData;
            DateTime to = DateTime.Now;
            TimeSpan timeSpan = to - from;
            int days = timeSpan.Days;
            int age = (int) (days / 365.242199);
            return age;
        }
        //method that calculates the BMI of the client
        public float BMICalculator()
        {
            double bmi = LastWeight(WeightsList) / (Height * Height);
            bmi = Math.Round(bmi, 2);
            return (float)bmi;
        }
        //method that returns the last weight of the weightslist
        public float LastWeight(List<float> list)
        {
            return list[(list.Count - 1)];
        }
        //method that calculates the category of the client based on BMI
        public String CategoryCalculator()
        {
            float currentBMI = BMICalculator();
            String category = null;
            if (currentBMI < 16.5)
            {
                category = "Gravemente sottopeso";
            }
            else if(currentBMI >= 16.5 && currentBMI <= 18.4)
            {
                category = "Sottopeso";
            }
            else if(currentBMI >= 18.5 && currentBMI <= 24.9)
            {
                category = "Normale";
            }
            else if (currentBMI >= 25 && currentBMI <= 30)
            {
                category = "Sovrappeso";
            }
            else if (currentBMI >= 30.1 && currentBMI <= 34.9)
            {
                category = "Obesità di primo grado";
            }
            else if (currentBMI >= 35 && currentBMI <= 40)
            {
                category = "Obesità di secondo grado";
            }
            else if (currentBMI >= 40.1)
            {
                category = "Obesità di terzo grado";
            }

            return category;
        }
        //method that returns the last date of datelist
        public DateTime LastDate(List<DateTime> list)
        {
            return list[(list.Count - 1)];
        }
        //method that search and returns the minimun weight of the weightslist
        public float FindMinimumWeight()
        {
            float attuale;
            float minimum = 0;
            float minL = 999999;
            for (int i = 0; i < this.WeightsList.Count; i++)
            {
                attuale = this.WeightsList[i];
                if (attuale < minL)
                {
                    minL = attuale;
                    minimum = attuale;
                }
            }
            return minimum;
        }

    }
}
