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

namespace Lab18_GUI_Entity
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static NorthwindEntities DBContext = new NorthwindEntities();

        public MainWindow()
        {
            
            InitializeComponent();

        }

        private void SearchButt_Click(object sender, RoutedEventArgs e)
        {
            var customer =
                from c in DBContext.Customers
                where c.City == searchBox.Text
                select c;

            listBox01.ItemsSource = customer.ToList<Customer>();
        }

        private void SearchOrder_Click(object sender, RoutedEventArgs e)
        {
            var order =

                from p in DBContext.Products
                join od in DBContext.Order_Details on p.ProductID equals od.ProductID
                join o in DBContext.Orders on od.OrderID equals o.OrderID
                join c in DBContext.Customers on o.CustomerID equals c.CustomerID
                where c.ContactName == showName.Text
                select p;

            listBox02.ItemsSource = order.ToList<Product>();

        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Customer customer = listBox01.SelectedItem as Customer;

                showName.Text = customer.ContactName;
            }
            catch
            {
                //
            }
        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Product product = listBox02.SelectedItem as Product;

                productName.Text = product.ProductName;
            }
            catch
            {
                //
            }
        }

        private void Productdetails_Click(object sender, RoutedEventArgs e)
        {
           


        }
    }
}
