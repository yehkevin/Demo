using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NLog;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}

/* 1) Add Nlog.Config via NuGet. The Nlog dependency will automatically be added too.
 * 2) Add MVVMLightlibs via NuGet.
 * 3) All classes have regions: members, format, properties, construction, commands, helpers.
 * 4) Dlls go in lib.
 * 5) You can delete all the code in the View or the ViewModel and it should still run. The View and View
 *    Model are uncoupled.
 */