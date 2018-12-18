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
using Lab18_GUI_Entity;

namespace Lab18_GUI_Entity
{
    
    /// <summary>
    /// Interaction logic for MyNewWindow.xaml
    /// </summary>
    public partial class MyNewWindow : Window
    {
        static NorthwindEntities DBContext = new NorthwindEntities();
        public MyNewWindow()
        {
            InitializeComponent();

            var productName =
                from p in DBContext.Products
                join od in DBContext.Order_Details on p.ProductID equals od.ProductID
                join o in DBContext.Orders on od.OrderID equals o.OrderID
                where o.OrderID == MainWindow.order.OrderID
                select p;

            changeName.Content = MainWindow.order.OrderDate;
            mehName.Content = MainWindow.order.RequiredDate;
            
            listBox01.ItemsSource = productName.ToList<Product>();
        }
        
    }
}
