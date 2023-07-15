using Gallery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Gallery.Commands.JsonHandling;

namespace Gallery.ViewModels
{
    public class GaleryViewModel : INotifyPropertyChanged { 
    
        private List<Galery> _Galery = paths;
        public List<Galery> Galery
        {
            get => _Galery;
            set
            {
                _Galery = value;
                PrpertyChanged();
            }
        }
        public GaleryViewModel()
        {

        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void PrpertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
