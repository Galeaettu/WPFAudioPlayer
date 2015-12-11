using Microsoft.Win32;
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

namespace NewspaperArticleBlog
{
    /// <summary>
    /// Interaction logic for Toolbar.xaml
    /// </summary>
    public partial class Toolbar : UserControl
    {
        public DocumentManager _docManager;
        public RichTextBox _rtb;
        public Window _mainWindow;

        public Toolbar()
        {
            InitializeComponent();
        }

        private void WindowManager()
        {
            _mainWindow = MainWindow.GetWindow(this);
            _rtb = (RichTextBox)_mainWindow.FindName("body");
            _docManager = new DocumentManager(_rtb);
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            WindowManager();
            if (_docManager.OpenDocument() == true)
            {

                TextBlock tb = (TextBlock)_mainWindow.FindName("status");
                tb.Text = _docManager._currentFile + " loaded";
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            WindowManager();
            if (_docManager.SaveDocument() == true)
            {
                TextBlock tb = (TextBlock)_mainWindow.FindName("status");
                tb.Text = _docManager._currentFile + " saved";
            }
        }

    }
}