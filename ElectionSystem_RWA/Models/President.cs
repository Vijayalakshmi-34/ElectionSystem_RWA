using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectionSystem_RWA.Models
{
    public class President
    {
        public int Id { get; set; }
        public string CandidateName { get; set; }
        public string CurrentOccupation { get; set; }
        public string PreviousRWAMember { get; set; }
        public string PartOfGovtPoliceNGO { get; set; }
        public string CriminalRecord { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Qualification Qualification { get; set; }
        public int QualificationId { get; set; }
        public int Vote { get; set; }
        //public Posting Posting { get; set; }
        //public int PostingId { get; set; }
    }
}