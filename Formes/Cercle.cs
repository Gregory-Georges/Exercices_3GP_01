using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cercle : FormeGeometrique
{
    private double _r;
    public double r
    {
        get{ return _r;  } 
        private set{ if (value >= 0) _r = value; else throw new ArgumentException("Dimensions invalides");  }
    }



    public Cercle(double r)
    {
        this.r = r;
    }

    public override double CalculerPerimetre()
    {
        return 2 * r * Math.PI;
    }
}
