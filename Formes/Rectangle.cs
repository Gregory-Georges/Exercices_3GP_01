using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle : FormeGeometrique
{
    private double _x;
    public double x
    {
        get { return _x; }
        private set{ if (value > 0) _x = value; else throw new ArgumentException("Dimensions invalides");  }
    }

    private double _y;
    public double y
    {
        get { return _y; }
        private set { if (value > 0) _y = value; else throw new ArgumentException("Dimensions invalides"); }
    }

    public Rectangle(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override double CalculerPerimetre()
    {
        return 2 * (x + y);
    }
}
