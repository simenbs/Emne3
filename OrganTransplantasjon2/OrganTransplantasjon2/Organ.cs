using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplantasjon2
{
    class Organ
    {
        public string Type { get; set; }
        public string HelseStatus { get; set; }
        public string DonorNavn { get; set; }

        public Organ(string type, string helseStatus, string donorNavn)
        {
            Type = type;
            HelseStatus = helseStatus;
            DonorNavn = donorNavn;
        }

    }
}
