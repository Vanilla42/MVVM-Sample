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

        public string Number00 { get; set; }
        public string Number01 { get; set; }
        public string Number02 { get; set; }
        public string Number03 { get; set; }
        public string Number10 { get; set; }
        public string Number11 { get; set; }
        public string Number12 { get; set; }
        public string Number13 { get; set; }
        public string Number20 { get; set; }
        public string Number21 { get; set; }
        public string Number22 { get; set; }
        public string Number23 { get; set; }
        public string Number30 { get; set; }
        public string Number31 { get; set; }
        public string Number32 { get; set; }
        public string Number33 { get; set; }

        public GameViewModel()
        {
            _field = new Field();
            SetNumbers();
        }

        private void SetNumbers()
        {
            Number00 = _field.Nodes[0, 0].Number.ToString();
            Number01 = _field.Nodes[0, 1].Number.ToString();
            Number02 = _field.Nodes[0, 2].Number.ToString();
            Number03 = _field.Nodes[0, 3].Number.ToString();

            Number10 = _field.Nodes[1, 0].Number.ToString();
            Number11 = _field.Nodes[1, 1].Number.ToString();
            Number12 = _field.Nodes[1, 2].Number.ToString();
            Number13 = _field.Nodes[1, 3].Number.ToString();

            Number20 = _field.Nodes[2, 0].Number.ToString();
            Number21 = _field.Nodes[2, 1].Number.ToString();
            Number22 = _field.Nodes[2, 2].Number.ToString();
            Number23 = _field.Nodes[2, 3].Number.ToString();

            Number30 = _field.Nodes[3, 0].Number.ToString();
            Number31 = _field.Nodes[3, 1].Number.ToString();
            Number32 = _field.Nodes[3, 2].Number.ToString();
            Number33 = _field.Nodes[3, 3].Number.ToString();
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
