using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MahappDataGridNoValidationError
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ItemA> Collection { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            Collection = new ObservableCollection<ItemA>();
            //Collection.Add(new ItemA() { Key = "item1", Value = "value1" });

        }
    }
}
