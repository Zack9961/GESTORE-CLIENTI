using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace Prova2
{
    class DBhandler
    {

        public List<Client> GetData()
        {
            List<Client> clients = null;
            JArray jsonArray = JArray.Parse(File.ReadAllText("clientsArray"));
            clients = jsonArray.ToObject<List<Client>>();
            return clients;
      
        }

        public void SaveData(List<Client> clients)
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(clients);
            File.WriteAllText("clientsArray", jsonString);
        }
        
    }



}
