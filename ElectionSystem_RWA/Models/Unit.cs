using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectionSystem_RWA.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitNumber { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
       

    }
}