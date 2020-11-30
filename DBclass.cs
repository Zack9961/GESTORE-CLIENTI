using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace CLIENTS_MANAGER
{
    class DBclass
    {
        //field for singleton
        private static DBclass instance;
        //implementation of the singleton pattern
        public static DBclass GetInstance()
        {
            if (instance == null)
                instance = new DBclass();
            return instance;
        }

        //method that gets the data from json file in the bin folder
        public List<Client> GetData()
        {
            List<Client> clients = null;
            JArray jsonArray = JArray.Parse(File.ReadAllText("clientsArray"));
            clients = jsonArray.ToObject<List<Client>>();
            return clients;
      
        }
        //method that save data writing a json file in the bin folder
        public void SaveData(List<Client> clients)
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(clients);
            File.WriteAllText("clientsArray", jsonString);
        }
        
       
    }



}
