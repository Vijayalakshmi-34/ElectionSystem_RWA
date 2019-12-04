using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectionSystem_RWA.ViewModels
{
    public class CheckingViewModel
    {
        public string Name { get; set; }
        public string UnitNumber { get; set; }
        public byte Age { get; set; }
        public string ErrorMessage { get; set; }
    }
}