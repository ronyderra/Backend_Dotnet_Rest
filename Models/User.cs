using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeworkS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string NameH { get; set; }
        public string NameE { get; set; }
        public DateTime BirthDate { get; set; }
        public int PersonalId { get; set; }
        public string City { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public int AccountNumber { get; set; }
    }
}