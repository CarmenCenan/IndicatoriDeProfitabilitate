using IndicatoriDeProfitabilitate.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.ViewModels
{
    public class RotatiePublicatiiViewModel
    {
        public string Nume_Companie { get; set; }
        public decimal Valoare_Indicator { get; set; }
        public List<Publicatii> Publicatii = new List<Publicatii>();
    }
}