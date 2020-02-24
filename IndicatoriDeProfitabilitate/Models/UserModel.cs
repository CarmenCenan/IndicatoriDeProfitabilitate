using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndicatoriDeProfitabilitate.Models
{
    public class UserModel
    {
        public Guid IdUser { get; set; }
        public Guid IdCompanie { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
    }
}