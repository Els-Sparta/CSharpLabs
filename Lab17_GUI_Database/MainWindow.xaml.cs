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

namespace Lab17_GUI_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // pull in entity
        // pull in the database 
        static NorthwindEntities DBContext = new NorthwindEntities();


        public MainWindow()
        {
            InitializeComponent();

            foreach (Lab17_GUI_Database.Customer customer in DBContext.Customers)
            {
                ListBox01.Items.Add(customer.ContactName + " lives in " + customer.City);
            }

        }





        private void Button01_Click(object sender, RoutedEventArgs e)
        {

            
                    
            var customers2 =
              from c in DBContext.Customers
              where c.City == typeBox.Text
              select c;


             ListBox02.ItemsSource = customers2.ToList<Customer>();
            
            // FOREACH (CUSTOMERS)
            // POPULATE LIST BOX

            // LINQ QUERY
            // POPULATE LISTBOX

            // SELECT GUY FROM FINLAND
            // 2ND BOTTOM ==> CLICK => PUSH FROM TEXTBOX HIS NEW NAME
            // var customers = LINQ QUERY
            // DB BINDING
            // ListBox01.ItemsSource = customers.CustomerName;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Customer customers3 = ListBox02.SelectedItem as Customer;

            showName.Text = customers3.ContactName;

        }

        string updatedName;

        public void UpdateBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(updateBox.Text != showName.Text)
            {
                updatedName = updateBox.Text;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Customer customer4 = ListBox02.SelectedItem as Customer;

            customer4.ContactName = updatedName;
            DBContext.SaveChanges();


        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            foreach (Lab17_GUI_Database.Customer customer in DBContext.Customers)
            {
                ListBox01.Items.Add(customer.ContactName + " lives in " + customer.City);
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Customer customer5 = ListBox02.SelectedItem as Customer;



            DBContext.Customers.Remove(customer5);
            DBContext.SaveChanges();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            int customerId = DBContext.Customers.Count<Customer>();
            customerId++;
            var c = new Customer
            {
                CustomerID = customerId.ToString(),
                CompanyName = "NULL",
                ContactName = newName.Text,
                ContactTitle = "NULL",
                Address = "NULL",
                City = "NULL",
                Region = "NULL",
                PostalCode = "NULL",
                Country = "NULL",
                Phone = "NULL",
                Fax = "NULL"
            };
        }
    }
}
