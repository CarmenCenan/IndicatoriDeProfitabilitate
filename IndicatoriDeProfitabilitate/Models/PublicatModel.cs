using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Models
{
    public class PublicatModel
    {
        public Guid IdPublicat { get; set; }
        public Guid IdCompanie { get; set; }
        public Guid IdUser { get; set; }
        public Guid IdRotatie { get; set; }
        public DateTime DateTimeAdded { get; set; }
    }
}