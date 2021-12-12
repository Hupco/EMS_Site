using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Client: Person
    {
        public string AdditionalInformation { get; set; }
    }
}
