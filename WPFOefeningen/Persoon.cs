using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFOefeningen
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Telefoonnr { get; set; }
        public string Groep { get; set; }
        public BitmapImage Foto { get; set; }
        public Persoon(string naam, string telefoonnr, string groep, BitmapImage foto)
        {
            Naam = naam;
            Telefoonnr = telefoonnr;
            Groep = groep;
            Foto = foto;
        }
    }
}
