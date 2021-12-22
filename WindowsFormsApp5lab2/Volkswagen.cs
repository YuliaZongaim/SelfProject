using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5lab2
{
    class Volkswagen
    {
        List<string> parts = new List<string>();
        
        public void Add(string part)
        {
            parts.Add(part);
        }
        
        public string ListParts()
        {
            string str = " ";

            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + Environment.NewLine;
            }

            return "" + str + Environment.NewLine  ;
        }
    }

  
}
