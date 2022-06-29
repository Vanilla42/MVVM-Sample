using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Sample.Models
{
    public class Node
    {
        private int _indexX;
        public int IndexX
        {
            get { return _indexX; }
            set { _indexX = value; }
        }

        private int _indexY;
        public int IndexY
        {
            get { return _indexY; }
            set { _indexY = value; }
        }

        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public Node(int indexX, int indexY)
        {
            IndexX = indexX;
            IndexY = indexY;
        }

        public Node(int indexX, int indexY, int number)
        {
            IndexX = indexX;
            IndexY = indexY;
            Number = number;
        }
    }
}
