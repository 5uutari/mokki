using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokkiApp
{
    class ClientUtils{
            static List<Client> clientList;

        public static List<Client> GetClient(){
            return clientList;
        }


        public static void SetServices(List<Service> ServiceList)
        {
            try
            {
                clientList = new List<Client>();
                if (clientList != null)
                {
                    foreach (Client s in clientList)
                    {
                        clientList.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorUtils.AddErrorMessage(ex.Message);
            }
        }


        public static int GetId()
        {
            try
            {
                int id = 1;
                List<int> idlist = new List<int>();
                foreach (Client c in clientList)
                {
                    idlist.Add(c.ClientID);
                }
                while (idlist.Contains(id))
                {
                    id++;
                }
                return id;
            }
            catch (Exception ex)
            {
                ErrorUtils.AddErrorMessage(ex.Message);
                return -1;
            }
        }




        public static void AddClient(Client c)
        {
            clientList.Add(c);
        }


    }
}
