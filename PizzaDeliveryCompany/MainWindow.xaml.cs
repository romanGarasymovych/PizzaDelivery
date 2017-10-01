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

namespace PizzaDeliveryCompany
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void PhoneNum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // Contact Information Properties
        public string Phone_Num
        {
            get { return PhoneNum.Text; }
            set { PhoneNum.Text = value; }
        }
        public string Address_Input
        {
            get { return Address.Text; }
            set { Address.Text = value; }
        }
        public string Email_Input
        {
            get { return Email.Text; }
            set { Email.Text = value; }
        }
        // MATH -------------------------------------------------------------
        // ------------------------------------------------------------------
        double total;
        string Size;
        public void AddToTotal(double addMore)
        {
            total += addMore;
        }
        // Check Size of Pizza
        public void SizeCheck()
        {
            if(Size_Small.IsChecked == true )
            {
                AddToTotal(10);
                Size = "Small";
            }
            if (Size_Medium.IsChecked == true)
            {
                AddToTotal(12);
                Size = "Medium";
            }
            if (Size_Large.IsChecked == true)
            {
                AddToTotal(14);
                Size = "Large";
            }
            if (Size_Extra.IsChecked == true)
            {
                AddToTotal(16);
                Size = "Extra Large";
            }
        }
        // Check for Toppings
        public void ToppingsCheck()
        {
            if (papperoni.IsChecked == true)
            {
                AddToTotal(4);

            }
            if (Extra_Cheese.IsChecked == true)
            {
                AddToTotal(3);

            }
            if (Beef.IsChecked == true)
            {
                AddToTotal(4);

            }
            if (Sun_Dried_Tom.IsChecked == true)
            {
                AddToTotal(3);

            }
            if (Bacon.IsChecked == true)
            {
                AddToTotal(4);

            }
            if (Ham.IsChecked == true)
            {
                AddToTotal(4);

            }
            if (Veggie.IsChecked == true)
            {
                AddToTotal(5);

            }
            if (Mushroom.IsChecked == true)
            {
                AddToTotal(3);

            }
            if (Parmesan.IsChecked == true)
            {
                AddToTotal(3);

            }
            if (Green_Pepper.IsChecked == true)
            {
                AddToTotal(3);

            }
            if (Cheddar_Cheese.IsChecked == true)
            {
                AddToTotal(3);

            }
            if (Tomatoes.IsChecked == true)
            {
                AddToTotal(3);

            }
        }
        // Check for Sauces
        public void SaucesCheck()
        {
            if (Sauce_Garlic.IsChecked == true)
            {
                AddToTotal(1);

            }
            if (Sauce_Bbq.IsChecked == true)
            {
                AddToTotal(1);

            }
            if (Sauce_Pesto.IsChecked == true)
            {
                AddToTotal(1);

            }

        }
        // Check for Drinks
        public void DrinksCheck()
        {
            if(Coke.IsChecked == true)
            {
                AddToTotal(2);

            }
            if (Coke_Zero.IsChecked == true)
            {
                AddToTotal(2);

            }
            if (Pepsi.IsChecked == true)
            {
                AddToTotal(2);

            }
            if (Sprite.IsChecked == true)
            {
                AddToTotal(2);

            }
            if (Ginger_Ale.IsChecked == true)
            {
                AddToTotal(2);

            }
            if (_7_Up.IsChecked == true)
            {
                AddToTotal(2);

            }
            if (Fanta.IsChecked == true)
            {
                AddToTotal(2);

            }
        }
        //Toppings Array
        public string [] Toppings = new string [] {""};
        //Reset Button
        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            Email.Text = null;
            Address.Text = null;
            PhoneNum.Text = null;

            Size_Small.IsChecked = false;
            Size_Medium.IsChecked = false;
            Size_Large.IsChecked = false;
            Size_Extra.IsChecked = false;

            papperoni.IsChecked = false;
            Extra_Cheese.IsChecked = false;
            Beef.IsChecked = false;
            Sun_Dried_Tom.IsChecked = false;
            Bacon.IsChecked = false;
            Ham.IsChecked = false;
            Veggie.IsChecked = false;
            Mushroom.IsChecked = false;
            Parmesan.IsChecked = false;
            Green_Pepper.IsChecked = false;
            Cheddar_Cheese.IsChecked = false;
            Tomatoes.IsChecked = false;

            Sauce_Garlic.IsChecked = false;
            Sauce_Bbq.IsChecked = false;
            Sauce_Pesto.IsChecked = false;

            Coke.IsChecked = false;
            Coke_Zero.IsChecked = false;
            Pepsi.IsChecked = false;
            Sprite.IsChecked = false;
            Ginger_Ale.IsChecked = false;
            _7_Up.IsChecked = false;
            Fanta.IsChecked = false;
        }
        //Confirm Button
        private void ButtonConfirm_Click(object sender, RoutedEventArgs e)
        {
            SizeCheck();
            ToppingsCheck();
            SaucesCheck();
            DrinksCheck();
            if (Email.Text == "" || PhoneNum.Text == "" || Address.Text == "")
            {
                MessageBox.Show("Please enter a valid Contact information!");
            }
            else
            {
                MessageBox.Show("\tYour Order will be ready soon!\n\nHere are the details:   " +
                    "\n\nPhone Number : " + Phone_Num +
                    "\nAddress : " + Address_Input +
                    "\nEmail : " + Email_Input +
                    "\n\tYour Order:" +
                    "\nPizza Size: " + Size +
                    "\nYour total is: $" + total);
                Close();
            }
        }
        private void Address_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Size_Small_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
