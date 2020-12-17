using System;
using System.Collections.Generic;
using System.Text;

namespace tcone
{
    public class TCircle
    {
        private double radius;

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0) Console.Write("The input isn't correct");
                else this.radius = value;
            }
        }

        public TCircle() => this.Radius = 1;
        public TCircle(double radius) => this.Radius = radius;
        public TCircle(TCircle circle) => this.Radius = circle.Radius;

        public override string ToString() { return $"Radius:{this.Radius}"; }

        public double GetLength() { return 2 * Math.PI * Radius; }

        public double GetSquare() { return Math.PI * Math.Pow(Radius, 2); }


        public static bool operator >(TCircle circle1, TCircle circle2) { return circle1.Radius > circle2.Radius; }
        public static bool operator <(TCircle circle1, TCircle circle2) { return circle1.Radius < circle2.Radius; }
        public static bool operator ==(TCircle circle1, TCircle circle2) { return circle1.Radius == circle2.Radius; }
        public static bool operator !=(TCircle circle1, TCircle circle2) { return circle1.Radius != circle2.Radius; }

        public static TCircle operator +(TCircle circle1, TCircle circle2)
        {
            return new TCircle(circle1.Radius + circle2.Radius);
        }

        public static TCircle operator -(TCircle circle1, TCircle circle2)
        {
            return new TCircle(Math.Abs(circle1.Radius - circle2.Radius));
        }

        public static TCircle operator *(TCircle circle1, double number)
        {
            return new TCircle(circle1.Radius * number);
        }

        public static TCircle operator *(double number, TCircle circle1)
        {
            return new TCircle(circle1.Radius * number);
        }

        public double GetSector(double angle)
        {
            return Math.PI * Math.Pow(this.Radius, 2) * (angle / 360);
        }


        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            if (this.GetType() != obj.GetType()) return false;
            TCircle temp = (TCircle)obj;
            return Radius == temp.Radius;
        }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }
    }
}
