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

namespace TestWPFAlpha
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DocumentStructureWindow : Window
    {
        public DocumentStructureWindow()
        {
            InitializeComponent();

            var newWin = new Window1(this);
            newWin.Show();  

        }

        private void buttonCloseDocumentStructureWindow_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
