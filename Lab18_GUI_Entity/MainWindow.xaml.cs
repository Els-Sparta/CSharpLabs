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


                from o in DBContext.Orders
                where o.CustomerID == customer.CustomerID
                select o;


            listBox02.ItemsSource = order.ToList<Order>();

        }

        Customer customer;

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                customer = listBox01.SelectedItem as Customer;

                showName.Text = customer.ContactName;
            }
            catch
            {
                //
            }
        }
        public static Order order;
        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
                order = listBox02.SelectedItem as Order;

                productName.Text = order.OrderID.ToString();


            }
            catch
            {
                //
            }
        }


        private void Productdetails_Click(object sender, RoutedEventArgs e)
        {

            var newWindow = new MyNewWindow();
            newWindow.Show();



        }
    }
}
