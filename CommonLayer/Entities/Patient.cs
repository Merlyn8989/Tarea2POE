using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string firstName {  get; set; }

        public string lastName { get; set; }

        public DateOnly dateOfBirth { get; set; }

        public string gender { get; set; }
    }
}
