using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VandanamVillas.Models
{
    public class AppConfig
    {
        
        public int Id { get; set; }

        [StringLength(20)]
        public string EmailSMTP { get; set; }

        [StringLength(50)]
        public string EmailSMTPUsername { get; set; }

        [StringLength(20)]
        public string EmailSMTPPassword { get; set; }

        [StringLength(50)]
        public string EmailFromID { get; set; }

        [StringLength(50)]
        public string EmailToID { get; set; }

        [StringLength(200)]
        public string EmailCCTo { get; set; }

        [StringLength(200)]
        public string EmailBCCTo { get; set; }
    }
}