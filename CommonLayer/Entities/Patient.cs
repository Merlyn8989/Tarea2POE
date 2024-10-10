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
        public string FirstName {  get; set; }

        public string LastName { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public string Gender { get; set; }
    }
}
