using Gallery.Commands;
using Gallery.Models;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Gallery.Commands.JsonHandling;

namespace Gallery.ViewModels
{
    public class AddImageViewModel : INotifyPropertyChanged
    {
        private string ?_path;
        public string? path
        {
            get { return _path; }
            set { _path = value; OnPropertyChanged(); }
            
        }

        public RealCommand? SelectCommand { get; set; } 
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string? name = null)
        {
            PropertyChanged!.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void SelectedImage(object? param)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.png|*.jpeg";
            if (openFileDialog.ShowDialog() == true)
            {
                path = openFileDialog.FileName;
                Galery galery = new Galery();
                if (JsonHandling.paths == null) JsonHandling.paths = new();
                galery.path = path;
                JsonHandling.paths.Add(galery);
                WriteData<List<Galery>>(paths, "images");
            }
        }
        public AddImageViewModel()
        {
            SelectCommand = new RealCommand(SelectedImage);
        }
    }
}
