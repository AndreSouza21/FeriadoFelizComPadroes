using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feriado
{
    internal class GPS : Posicao
    {
        public double lat;
        public double lon;
        public GPS(double lat, double lon) 
        {
            this.lat = lat;
            this.lon = lon;
        }
        public double GetLat() 
        {  
            return lat; 
        }
        public double GetLong() 
        {  
            return lon; 
        }
    }
}

