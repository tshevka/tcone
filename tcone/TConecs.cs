using System;
using System.Collections.Generic;
using System.Text;

namespace tcone
{
    class TCone : TCircle
    {
        private double height;

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                else this.height = value;
            }
        }

        public TCone() : base()
        {
            Height = 1;
        }

        public TCone(double height)
        {
            this.height = height;
        }

        public TCone(double radius, double height) : base(radius) => this.Height = height;

        public override string ToString() => base.ToString() + $"\tHeight:{this.Height}";

        public TCone(TCircle circle, double height) : base(circle)
        {
            this.Height = height;
        }

        public double Volume()
        {
            return (1 / 3) * Math.PI * Math.Pow(Radius, 2) * Height;
        }
        public static bool operator >(TCone cone1, TCone cone2)
        {
            return cone1.Volume() > cone2.Volume();
        }

        public static bool operator <(TCone cone1, TCone cone2)
        {
            return cone1.Volume() < cone2.Volume();
        }

        public static bool operator ==(TCone cone1, TCone cone2)
        {
            return cone1.Volume() == cone2.Volume();
        }

        public static bool operator !=(TCone cone1, TCone cone2)
        {
            return cone1.Volume() != cone2.Volume();
        }


        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            if (this.GetType() != obj.GetType()) return false;
            TCone temp = (TCone)obj;
            return Volume() == temp.Volume();
        }

        public override int GetHashCode()
        {
            return Volume().GetHashCode();
        }
    }
}
