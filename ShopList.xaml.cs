using System.Collections.ObjectModel;
using System.Windows;
using System.Linq;

namespace OnStore
{
    /// <summary>
    /// Interaction logic for ShopList.xaml
    /// </summary>
    public partial class ShopList : Window
    {
        public ObservableCollection<Product> SelectedItems { get; set; }
        public ShopList(ObservableCollection<Product> ShopList)
        {
            InitializeComponent();
            SelectedItems = ShopList;
            DataContext = this;
        }

        private void BuySelectedProducts(object sender, RoutedEventArgs e)
        {
            var items = new ObservableCollection<Product>(SelectedItems);
            foreach (var item in items)
            {
                if(item.IsCheck == true)
                {
                    SelectedItems.Remove(item);
                }
            }
        }

        private void DeleteAllProducts(object sender, RoutedEventArgs e)
        {
            SelectedItems.Clear();
        }
    }
}
