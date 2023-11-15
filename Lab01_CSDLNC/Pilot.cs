using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_CSDLNC
{
    public class Pilot
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Pilot(string name, int points)
        {
            Name = name;
            Points = points;
        }
        public void AddPoints(int points)
        {
            Points += points;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", Name, Points);
        }
    }
}
