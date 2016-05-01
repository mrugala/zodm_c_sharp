using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZODMokienko
{
    static class ZDH
    {
        public const double a2 = 12;
        public const double d4 = 10;
    }

    public class Matrix
    {
        public class SizeMismatch : Exception
        {
            public SizeMismatch()
            {
            }

            public SizeMismatch(string message)
                : base(message)
            {
            }
        }

        public Matrix(int size_m, int size_n)
        {
            m = size_m;
            n = size_n;
            m_data = new double[m * n];
        }

        public Matrix(int size_m, int size_n, double[] data)
        {
            m = size_m;
            n = size_n;
            if (data.Length != (m * n))
                throw new SizeMismatch("Data length inconsistent with the dimensions of the matrix");
            m_data = data;
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            if(!left.isMultiplicableBy(right))
                throw new SizeMismatch("Can't multiply matrices");
            Matrix temp = new Matrix(left.getSize().Item1, right.getSize().Item2);
            
            for (int i = 1; i <= left.getSize().Item1; ++i) 
                for (int j = 1; j <= right.getSize().Item2; ++j) 
                    for (int k = 1; k <= left.getSize().Item2; k++) 
                        temp[i,j] += left[i,k] * right[k,j];
            return temp;
        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            if (!left.isSameSize(right))
                throw new SizeMismatch("Can't add matrices");
            Matrix temp = new Matrix(left.getSize().Item1, left.getSize().Item2);

            for (int i = 1; i <= temp.getSize().Item1; ++i)
                for (int j = 1; j <= temp.getSize().Item2; ++j)
                    temp[i, j] = left[i, j] + right[i, j];
            return temp;
        }

        public static bool operator ==(Matrix left, Matrix right)
        {
            return (left.ToString() == right.ToString()) && (left.m == right.m) && (left.n == right.n);
        }

        public static bool operator !=(Matrix left, Matrix right)
        {
            return !((left.ToString() == right.ToString()) && (left.m == right.m) && (left.n == right.n));
        }

        public double this[int i, int j]
        {
            get { return m_data[n * (i - 1) + (j - 1)]; }
            set { m_data[n * (i - 1) + (j - 1)] = value; }
        }

        private bool isMultiplicableBy(Matrix m)
        {
            return n == m.getSize().Item1; 
        }

        private bool isSameSize(Matrix m)
        {
            return getSize().Item1 == m.getSize().Item1 && getSize().Item2 == m.getSize().Item2;
        }

        public Tuple<int, int> getSize() 
        {
            return new Tuple<int, int> (m, n);
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 1; i <= m; ++i)
            {
                for (int j = 1; j <= n; ++j)
                    output += this[i, j].ToString("0.00") + " ";
                output += "\n";
            }
            return output;
        }

        private double[] m_data;
        private int m;
        private int n;
    }

    public class Rotation
    {
        public Rotation(decimal Alfa, decimal Beta, decimal Gamma)
        {
            double alfa = Math.PI / 180 * (double)Alfa;
            double beta = Math.PI / 180 * (double)Beta;
            double gamma = Math.PI / 180 * (double)Gamma;

            r = new Matrix(3, 3);
            Matrix Rotx = new Matrix(3, 3, new double[9] { 1, 0, 0, 0, Math.Cos(alfa), -Math.Sin(alfa), 0, Math.Sin(alfa), Math.Cos(alfa) });
            Matrix Roty = new Matrix(3, 3, new double[9] { Math.Cos(beta), 0, Math.Sin(beta), 0, 1, 0, -Math.Sin(beta), 0, Math.Cos(beta) });
            Matrix Rotz = new Matrix(3, 3, new double[9] { Math.Cos(gamma), -Math.Sin(gamma), 0, Math.Sin(gamma), Math.Cos(gamma), 0, 0, 0, 1 });

            r = Rotz * Roty;
            r *= Rotx;
        }
        private Matrix r;
        public double this[int i, int j]
        {
            get { return r[i, j]; }
        }
        public override string ToString()
        {
            return r.ToString();
        }
    }

    public class InputData {
        public InputData(decimal dX, decimal dY, decimal dZ, decimal dAlfa, decimal dBeta, decimal dGamma)
        {
            X = dX;
            Y = dY;
            Z = dZ;
            Alfa = dAlfa;
            Beta = dBeta;
            Gamma = dGamma;
        }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        public decimal Alfa { get; set; }
        public decimal Beta { get; set; }
        public decimal Gamma { get; set; }
    }

    class ZODM
    {
        public ZODM(InputData input)
        {
            inD = input;
            q = new double[6];
        }

        public void calculate()
        {
            rot = new Rotation(inD.Alfa, inD.Beta, inD.Gamma);
            //Console.WriteLine(rot.ToString());

            double len = Math.Sqrt(Math.Pow((double)inD.X, 2) + Math.Pow((double)inD.Y, 2) + Math.Pow((double)inD.Z, 2));
            if (len > 22.0)
            {
                inD.X *= (decimal)(22.0 / len);
                inD.Y *= (decimal)(22.0 / len);
                inD.Z *= (decimal)(22.0 / len);
                len = Math.Sqrt(Math.Pow((double)inD.X, 2) + Math.Pow((double)inD.Y, 2) + Math.Pow((double)inD.Z, 2));
            }

            q[1] = Math.Atan2((double)inD.Y, (double)inD.X);
            double temp = rot[2, 3] * Math.Cos(q[1]) - rot[1, 3] * Math.Sin(q[1]);
            q[4] = Math.Atan2(Math.Sqrt(1 - Math.Pow(temp, 2)), temp);

            if (Math.Sin(q[4]) != 0)
            {
                double q23 = Math.Atan2(rot[3, 3], rot[2, 1] * Math.Cos(q[1]) + rot[1, 1] * Math.Sin(q[1]));
                temp = -ZDH.d4 * Math.Sin(q23) + (double)inD.X * Math.Cos(q[1]) + (double)inD.Y * Math.Sin(q[1]);
                q[2] = Math.Atan2(ZDH.d4 * Math.Cos(q23) - (double)inD.Z, temp);
                temp = (Math.Pow((double)inD.X, 2) + Math.Pow((double)inD.Y, 2)
                    + Math.Pow((double)inD.Z, 2) - Math.Pow(ZDH.a2, 2) - Math.Pow(ZDH.d4, 2)) / (2 * ZDH.a2 * ZDH.d4);
                q[3] = Math.Atan2(temp, Math.Sqrt(1 - Math.Pow(temp, 2)));
                q[5] = Math.Atan2((-rot[3, 1] * Math.Cos(q23) - Math.Sin(q23))
                    * (rot[1, 1] * Math.Cos(q[1]) + rot[2, 1] * Math.Sin(q[1])),
                    (-rot[3, 2] * Math.Cos(q23) - Math.Sin(q23))
                    * (rot[1, 2] * Math.Cos(q[1]) + rot[2, 2] * Math.Sin(q[1])));
            }
            else
            {
                double q235 = Math.Atan2(rot[3, 1], rot[3, 2]);
                temp = (Math.Pow((double)inD.X, 2) + Math.Pow((double)inD.Y, 2)
                    + Math.Pow((double)inD.Z, 2) - Math.Pow(ZDH.a2, 2) - Math.Pow(ZDH.d4, 2)) / (2 * ZDH.a2 * ZDH.d4);
                q[3] = Math.Atan2(Math.Sqrt(1 - Math.Pow(temp, 2)), temp);
                q[2] = Math.Atan2((double)inD.Z, Math.Sqrt(Math.Pow((double)inD.X, 2) + Math.Pow((double)inD.Y, 2)))
                    + Math.Atan2(ZDH.d4 * Math.Sin(q[3]), ZDH.a2 + ZDH.d4 * Math.Cos(q[3]));
                q[5] = Math.Atan2(rot[3, 1], rot[3, 2]) - q[2] - q[3];
                Console.WriteLine("przypadek osobliwy");
            }
        }

        public double this[int i]
        {
            get { return q[i] * (180 / Math.PI); }
            set { q[i] = value * Math.PI/180; }
        }

        private InputData inD;
        private double[] q;
        private Rotation rot;
    }
}
