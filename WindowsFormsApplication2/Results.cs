using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    internal class Results
    {
        public double Physics { set; get; }
        public double Chemistry { set; get; }
        public double Math { set; get; }

        public double GetAverage()

        {
            double Average;
            Average=(Physics + Chemistry + Math)/3;
            return Average;


        }

        public string GetGradeLetter()
        {
            if (GetAverage() >= 80 && GetAverage() <= 100)
                return "A+";
            else if (GetAverage() >= 70 && GetAverage() <= 100)
                return "A";
            else if (GetAverage() >= 60 && GetAverage() <= 100)
                return "B";
            else if (GetAverage() >= 50 && GetAverage() <= 100)
                return "B";
            
              else 
                  return "YOU HAVE FAILLED";
        }
    }

}
