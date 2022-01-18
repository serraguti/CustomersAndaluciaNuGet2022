using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndaluciaNuGet.Models
{
    public class Customer
    {
        [JsonProperty("CustomerID")]
        public String IdCustomer { get; set; }
        [JsonProperty("CompanyName")]
        public String Company { get; set; }
        [JsonProperty("ContactName")]
        public String Name { get; set; }
        [JsonProperty("City")]
        public String City { get; set; }
    }
}
