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

        private Numbers _number;
        public Numbers Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private List<Numbers> _numbersAvailable;
        public List<Numbers> NumbersAvailable
        {
            get { return _numbersAvailable; }
            set { _numbersAvailable = value; }
        }

        public Node(int indexX, int indexY)
        {
            IndexX = indexX;
            IndexY = indexY;
        }

        public Node(int indexX, int indexY, Numbers number)
        {
            IndexX = indexX;
            IndexY = indexY;
            Number = number;
        }
    }
}
