using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8_3
{
    internal class Film
    {
        public string FilmId { get; set; }
        public string FilmName { get; set; }
        public int Price { get; set; }
        public Film (string FilmId, string FilmName, int Price)
        {
            this.FilmId = FilmId;
            this.FilmName = FilmName;
            this.Price = Price;
        }
        public override string ToString()
        {
            return FilmId + " : " + FilmName + " : " + Price;
        }
    }
}
