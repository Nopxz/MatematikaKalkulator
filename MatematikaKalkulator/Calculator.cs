using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;



namespace MatematikaKalkulator
{
    public class Calculator
    {
        public string User(String name)
        {
            return name;
        }

        public int Tambah(int a, int b)
        {
            return a + b;
        }
        public int Kurang(int a, int b)
        {
            return a - b;
        }
    }
}
