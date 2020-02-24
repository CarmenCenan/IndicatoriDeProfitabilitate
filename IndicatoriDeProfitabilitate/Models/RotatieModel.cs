using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Models
{
    public class RotatieModel
    {
        public Guid IdRotatie { get; set; }
        public Guid IdCompanie { get; set; }
        public Guid IdUser { get; set; }
        public decimal Cost_marfa_vanduta { get; set; }
        public decimal Valoare_stoc_mediu { get; set; }
        public decimal Valoare_indicator { get; set; }
        public bool Public { get; set; }
    }
}