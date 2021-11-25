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

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Холодильник",
                Price = 40000,
                Location = "Data/1.jpg",
                ProductType = ProductTypes.Electronic
            });
            products.Add(new Product()
            {
                Name = "Хлеб",
                Price = 40,
                Location = "Data/2.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                Name = "Вода",
                Price = 80,
                Location = "Data/2.png",
                ProductType = ProductTypes.Food
            });

            lstBox.ItemsSource = products;
        }
    }
}
