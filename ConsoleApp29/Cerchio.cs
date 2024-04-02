using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Cerchio
    {
        private object value;

        public double raggio { get; }

        public Cerchio(double raggio)
        {
            this.raggio = raggio;
        }
        public Cerchio(object value)
        {
            this.value = value;
        }

        public static Cerchio operator +(Cerchio a, Cerchio b)
        {

            return new Cerchio((a.raggio * a.raggio * 3.14) + (b.raggio * b.raggio * 3.14));
        }
        public static Cerchio operator -(Cerchio a, Cerchio b)
        {
            return new Cerchio(Math.Pow((a.raggio - b.raggio), 2) * 3.14);
        }
        public static bool operator ==(Cerchio a,Cerchio b)
        {
            if (object.ReferenceEquals(a, null))
            {
                if (object.ReferenceEquals(b, null))
                
                    return true;
                return false;
                
            
            }
                if (object.ReferenceEquals(b, null))
            {
                return false;
            }
                return a.raggio == b.raggio;
            
        }
        public static bool operator !=(Cerchio a, Cerchio b)
        {
            return !(a == b);
        }
        public static Cerchio Parse(string s)
        {
            String[] parts = s.Split();
            return new Cerchio(int.Parse(parts[0]));
        }
        public override string ToString()
        {
            return string.Format("C^{0}", raggio);
        }

    }
}
