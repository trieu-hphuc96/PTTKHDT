using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Place { get; set; }
        public string CivilID { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public Staff(string id)
        {
            this.ID = id;
        }
    }
}
