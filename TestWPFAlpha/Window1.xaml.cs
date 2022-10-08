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
using System.Windows.Shapes;

namespace TestWPFAlpha
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private DocumentStructureWindow _documentStructureWindow;

        public Window1(DocumentStructureWindow documentStructureWindow)
        {
            InitializeComponent();
            _documentStructureWindow = documentStructureWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tds = _documentStructureWindow.TreeViewDocumentStructure;
            tds.Items.Add(new TreeViewItem() { Header = DateTime.Now.ToString("yyMMdd_HHmmss_fff")} );
        }
    }
}
