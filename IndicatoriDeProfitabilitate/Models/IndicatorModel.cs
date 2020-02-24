using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Models
{
    public class IndicatorModel
    {
        public Guid IdIndicator { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public string Formula_de_calcul { get; set; }
    }
}