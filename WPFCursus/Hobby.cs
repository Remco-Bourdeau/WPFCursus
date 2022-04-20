using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFCursus
{
    public class Hobby
    {
        public string Categorie { get; set; }
        public string Activiteit { get; set; }
        public BitmapImage Symbool { get; set; }
        public Hobby(string categorie, string activiteit, BitmapImage symbool)
        {
            Categorie = categorie;
            Activiteit = activiteit;
            Symbool = symbool;
        }
    }
}
