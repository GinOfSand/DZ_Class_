using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Class_
{
    internal class Square
    {
        public int wall{ get; set; }
        string simbol { get; set; }
        public Square(int walls = 2, string simb = "*") { wall = walls; simbol = simb; }

        public override string ToString() 
        {
            string sq = null; 
            for (int i = 0; i < wall; i++)
            {
                for (int j = 0; j < wall; j++)
                {
                    sq += simbol+" ";
                }
                sq += "\n";
            }
            return sq;
        }

    }
}
