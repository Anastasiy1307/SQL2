using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQL.Entities;

namespace SQL.Models
{
    public class Climbers
    {
        public Climbers(climber climber) 
        {
            Cod_climber = climber.cod_climber;
            Name_ = climber.name_;
            familia = climber.familia;
            otchestvo = climber.otchestvo;
            cod_adres = climber.cod_adres;
            telefon = climber.telefon;
            cod_pasporta = climber.cod_pasporta;
            email = climber.email;
            cod_podgotovki = (int)climber.cod_podgotovki;
            Cod_dogovora = climber.Cod_dogovora;
            image = climber.image;
        }
        public int Cod_climber { get; set; }
        public string Name_ { get; set; }
        public string familia { get; set; }
        public string otchestvo { get; set; }
        public int cod_adres { get; set; }
        public string telefon { get; set; }
        public int cod_pasporta { get; set; }
        public string email { get; set; }
        public int cod_podgotovki { get; set; }
        public int Cod_dogovora { get; set; }
        public string image { get; set; }
    }
}