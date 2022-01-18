using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using CustomersAndaluciaNuGet.Models;

namespace CustomersAndaluciaNuGet
{
    public class NorthwindData
    {
        //CUANDO LLAMAMOS A UN SERVICIO LAS LLAMADAS DEBEN
        //SER ASINCRONAS
        public async Task<CustomerList> GetCustomersListAsync()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            string url = 
                "https://services.odata.org/V4/Northwind/Northwind.svc/Customers";
            string datajson =
                await client.DownloadStringTaskAsync(url);
            //EXTRAEMOS LOS DATOS DE STRING Y LOS CONVERTIMOS
            //A CLASES UTILIZANDO NEWTONSOFT
            CustomerList customers =
                JsonConvert.DeserializeObject<CustomerList>(datajson);
            return customers;
        }
    }
}
