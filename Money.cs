using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCs4
{
    internal class Money
    {
        private int rubl;
        private int penny;
        public int Rubl {
            get { 
                return rubl;
            }
            set { 
                if (value >=0) rubl = value;
                else rubl = 0;
            }
        }
        public int Penny
        {
            get { 
                return penny;
            }
            set { 
                if (value>=0) penny = value;
                else penny = 0;
            }
        }
    }
}
