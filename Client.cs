using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    public class Client
    {
        public String name;
        public String surname;
        public String sex;
        public String weight;
        public String height;

        public Client(String name,String surname,String weight,String height,String sex)
        {
            this.name = name;
            this.surname = surname;
            this.weight = weight;
            this.height = height;
            this.sex = sex;

        }

        public String getName()
        {
            return this.name;
        }





    }
}
