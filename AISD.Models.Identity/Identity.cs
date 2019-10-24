using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISD.Models.Identity
{
    public class Identity
    {
        public int id = 1;
        public string firstName { get; set; } = "Henry";
        public string lastName = "Tang";
        public Boolean adminAccess = true;
    }
}
