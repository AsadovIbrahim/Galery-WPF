using Gallery.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Gallery.Views;
using Gallery.ViewModels;

namespace Gallery
{
   
    public partial class MainWindow : Window
    {
        public RealCommand AddCommand { get; set; }
        public RealCommand GaleryCommand { get; set; }  
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            AddCommand = new RealCommand(AddImage);
            GaleryCommand = new RealCommand(Galery);
        }
        private void AddImage(object? param)
        {
            MainFrame.Content = new Page1();
        }
        private void Galery(object? param)
        {
            MainFrame.Content = new Page2();

        }
    }
}
