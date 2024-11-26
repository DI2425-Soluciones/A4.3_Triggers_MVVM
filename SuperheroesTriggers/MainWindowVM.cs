using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesTriggers
{
    internal class MainWindowVM : INotifyPropertyChanged
    {
        private List<Superheroe> heroes;

        private Superheroe _heroeActual;
        public Superheroe HeroeActual
        {
            get { return _heroeActual; }
            set
            {
                _heroeActual = value;
                NotifyPropertyChanged("HeroeActual");
            }
        }

        private int _total;
        public int Total
        {
            get { return _total; }
            set
            {
                _total = value;
                NotifyPropertyChanged("Total");
            }
        }

        private int _actual;
        public int Actual
        {
            get { return _actual; }
            set
            {
                _actual = value;
                NotifyPropertyChanged("Actual");
            }
        }

        public MainWindowVM()
        {
            heroes = DatosServicio.GetSamples();
            HeroeActual = heroes[0];
            Total = heroes.Count;
            Actual = 1;
        }

        public void Anterior()
        {
            if (Actual > 1)
            {
                Actual--;
                HeroeActual = heroes[Actual - 1];
            }
        }

        public void Siguiente()
        {
            if (Actual < Total)
            {
                Actual++;
                HeroeActual = heroes[Actual - 1];
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
