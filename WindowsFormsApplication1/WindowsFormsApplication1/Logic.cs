using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    class Logic
    {
       // private const double _a = 2;
        //private const double _b = 1;
        private readonly double _delta; //= _a/_b;
       // private const int _N = 8;
        private const double Pi = 3.1415926558;
        private readonly double _gama;
        private readonly double[] _ksikk;
        private readonly double[] _ksiii;
        private readonly double[,] _xkyk;
        private double[,] _xiyi;

        public double[,] Xkyk
        {
            get { return _xkyk; }
        }
        public double[,] Xiyi
        {
            get { return _xiyi; }
        }

        public Logic(double a,double b,int n)
        {
            _ksikk = new double[n+1];
            _ksiii = new double[n + 1];
            _xkyk = new double[2, n + 1];
            _xiyi = new double[2, n + 1];
            _delta = a/b;
            _gama = 2*Pi/n;
            _ksiii = Ksi(_gama, 1/2,n);
            _ksikk = Ksi(_gama, 0,n);
            _xkyk = Cord(_delta, _ksikk,n);
            _xiyi = Cord(_delta, _ksiii,n);
        }
        //Функция фозврата ксишек
        private static double[] Ksi(double g,byte p,int n)
        {
            var ks = new double[n+1];
            for (var j = 0; j < n+1; j++)
            {
                ks[j] = (j + p)*g;
            }
            return ks;
        }
        //Функция возврата координат
        private static double[,] Cord(double d, IList<double> ksi, int n)
        {
            var cord = new double[2,n+1];
                for (var k = 0; k < n+1; k++)
                {
                    cord[0,k] = -Math.Cos(ksi[k]);
                    cord[1,k] = Math.Sin(ksi[k])/d;
                }
            return cord;
        }
    }
}
