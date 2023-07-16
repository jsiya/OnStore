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

namespace OnStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }


        public Product SelectedProduct
        {
            get { return (Product)GetValue(SelectedProductProperty); }
            set { SetValue(SelectedProductProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedProduct.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedProductProperty =
            DependencyProperty.Register("SelectedProduct", typeof(Product), typeof(MainWindow));


        public ObservableCollection<Product> MyShopList { get; set; }
        public float TotalAmount { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Products = new ObservableCollection<Product> {
                new Product(Guid.NewGuid(),"Nur", "Bread", 2.29f, "https://ibox.ams3.digitaloceanspaces.com/products/1/2022/Aprel/75041220.3587.jpg"),
                new Product(Guid.NewGuid(),"Sirab", "Water", 0.80f, "https://static.insales-cdn.com/images/products/1/7023/447568751/sirab-1.jpg"),
                new Product(Guid.NewGuid(),"AzerSud", "Milk", 2.15f, "https://neptun.az/image/cache/catalog/azersud22-1000x1000.jpg?v=9"),
                new Product(Guid.NewGuid(),"President", "Cheese", 3.10f, "https://bazarstore.az/1893-large_default/president-yagli-pendir-150-gr.jpg"),
                new Product(Guid.NewGuid(),"Milla", "Yogurt", 1.45f, "https://bazarstore.az/7647-large_default/mlla-qatiq-02-ml-15-.jpg"),
                new Product(Guid.NewGuid(),"AzerCay", "Tea", 5.96f, "https://bazarstore.az/13-large_default/azercay-buket-100-gr.jpg"),
                new Product(Guid.NewGuid(),"Tess", "Green Tea", 2.79f, "https://neptun.az/image/cache/catalog/Untitled-ST-1000x1000.jpg?v=9"),
                new Product(Guid.NewGuid(),"Nescafe", "Coffee", 7.19f, "https://m.media-amazon.com/images/I/71z9qM84SKL.jpg"),
                new Product(Guid.NewGuid(),"Snickers", "Choclate", 1.75f, "https://m.media-amazon.com/images/I/51JObrhv-lL.jpg"),
                new Product(Guid.NewGuid(),"Haribo", "Gummy Bears", 2.85f, "https://justasianfood.com/cdn/shop/products/HariboGoldBearsGummiCandy5oz_front_2048x.jpg?v=1633720331"),
                new Product(Guid.NewGuid(),"Doritos", "Chips", 2.70f,"https://marsoverseas.az/wp-content/uploads/2022/02/Doritos-Taco-edviyyatli.jpg"),
                new Product(Guid.NewGuid(),"Ankara", "Pasta", 2.16f,"https://static.ticimax.cloud/36210/uploads/urunresimleri/buyuk/makarna-eristeankaraan-008.100.060-d-4a8d.jpg"),
                new Product(Guid.NewGuid(),"BizimTarla", "Pickle", 3.85f,"https://cdn.megamart.az/products/87176-154782-thickbox.jpg"),
                new Product(Guid.NewGuid(),"Sun", "Napkin", 1.15f,"https://bazarstore.az/23603-large_default/sun-salfet-maxi-195-dd.jpg"),
                new Product(Guid.NewGuid(),"Fairy", "Dish Soap", 2.15f,"https://images.migrosone.com/sanalmarket/product/30619668/30619668-51e6db-1650x1650.jpg"),
            };
            MyShopList = new();
            TotalAmount = 0;

        }

        private void AddToBasket(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            SelectedProduct = button.Tag as Product;
            SelectedProduct.IsCheck = true;
            MyShopList.Add(new Product(SelectedProduct));
        }
        private void OpenBasketListWindow(object sender, RoutedEventArgs e)
        {
            ShopList shopList = new ShopList(MyShopList);
            shopList.Show();
        }
    }
}
