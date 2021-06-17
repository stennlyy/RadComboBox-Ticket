using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace ComboBoxWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = this;

            this.Customers = new ObservableCollection<Customer>
            {
                new Customer { Name = "Hogn", Id=1},
                new Customer { Name = "Michael", Id=2},
                new Customer { Name = "George", Id=3},
                new Customer { Name = "Rosen", Id=4},
            };

        }

        public ObservableCollection<Customer> Customers { get; set; }
    }
}