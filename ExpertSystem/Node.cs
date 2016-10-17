using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    public class Node
    {
        public int yes;
        public int no;
        public String text;
        public String file;
        public Image img;

        public Node(int y, int n, String t)
        {
            yes = y;
            no = n;
            text = t;

            img = null;
            file = String.Empty;
        }

        public Node(String f, String t)
        {
            file = f;
            text = t;
        }
    }
}
