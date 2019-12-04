using ElectionSystem_RWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectionSystem_RWA.ViewModels
{
    public class PostingViewModel
    {
        public List<President> President { get; set; }
        public List<VicePresident> VicePresident { get; set; }
        public List<Secretary> Secretary { get; set; }
        public List<Treasurer> Treasurer { get; set; }
        public List<Members> Members { get; set; }
    }
}