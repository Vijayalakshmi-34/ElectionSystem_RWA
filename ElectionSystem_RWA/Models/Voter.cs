using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectionSystem_RWA.Models
{
    public class Voter
    {
        public int Id { get; set; }
        public string President { get; set; }
        public string VicePresident { get; set; }
        public string Secretary { get; set; }
        public string Treasure { get; set; }
        public string Member1 { get; set; }
        public string Member2 { get; set; }
        public string Member3 { get; set; }
        public string Member4 { get; set; }
        public string Member5 { get; set; }
        public string Member6 { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
    }
}