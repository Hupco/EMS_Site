using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Models
{
    public class Training
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Training(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
