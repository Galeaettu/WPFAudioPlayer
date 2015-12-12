using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for BlogControl.xaml
    /// </summary>
    public partial class BlogControl : UserControl
    {
        List<User> items = new List<User>();
        private static int count = 0;

        public BlogControl()
        {
            InitializeComponent();
            //List<User> items = new List<User>();
            //items.Add(new User() { Timestamp = DateTime.Now, Username = "ChrisGalea", Comment = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", });
            //items.Add(new User() { Timestamp = DateTime.Now, Username = "George", Comment = "Hmm hmm yes yes", });
            //comments.ItemsSource = items;

            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(comments.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));

            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            items.Add(new User() { Timestamp = DateTime.Now, Username = Username.Text, Comment = Comment.Text, });

            if(count >= 6)
            {
                count--;
                items.RemoveAt(0);
                comments.ItemsSource = items;

                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(comments.ItemsSource);
                view.SortDescriptions.Add(new SortDescription("Timestamp", ListSortDirection.Descending));
            }
            else
            {
                comments.ItemsSource = items;

                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(comments.ItemsSource);
                view.SortDescriptions.Add(new SortDescription("Timestamp", ListSortDirection.Descending));
            }          
            
        }
    }

    public class User
    {
        public DateTime Timestamp { get; set; }

        public string Username { get; set; }

        public string Comment { get; set; }
    }
}
