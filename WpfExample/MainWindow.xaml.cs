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

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InfoCommand _infoCommand = new InfoCommand();

        AddCommand _addNameCommand = new AddCommand();
        public AddCommand AddNameCommand
        {
            get { return _addNameCommand; }
        }

        RemoveCommand _removeNameCommand = new RemoveCommand();
        public RemoveCommand RemoveNameCommand
        {
            get { return _removeNameCommand; }
        }

        public InfoCommand InformationCommand
        {
            get { return _infoCommand; }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new NamesList();
        }
    }
}
