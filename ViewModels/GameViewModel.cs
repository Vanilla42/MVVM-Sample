using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Sample.Models;

namespace MVVM_Sample.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        private Field _field;

        public string[,] Numbers;

        public GameViewModel()
        {
            _field = new Field();
            Numbers = GetNumbers();
        }

        private string[,] GetNumbers()
        {
            string[,] numbers = new string[_field.Nodes.GetLength(0), 4];

            for (int i = 0; i < _field.Nodes.GetLength(0); i++)
            {
                for (int j = 0; j < _field.Nodes.GetLength(1); j++)
                {
                    numbers[i, j] = _field.Nodes[i, j].Number.ToString();
                }
            }

            return numbers;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, e);
            }
        }
    }
}
