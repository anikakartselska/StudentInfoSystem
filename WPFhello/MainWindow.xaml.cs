using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;

        }
        private void btnHello_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (txtName.Text.Length <= 2) {
                MessageBox.Show("Името трябва да е с дължина >2");
            }
            else
            {
                MessageBox.Show("Здрасти " + txtName.Text + "!!! \nТова е твоята първа програма на Visual Studio 2012!");
            }
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
           MessageBoxResult close = MessageBox.Show("Are you sure you want to leave?");
            if(close == MessageBoxResult.None)
            {
                e.Cancel = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int N;
            if (int.TryParse(n.Text, out N))
            {
               result.Text = GetFactorial(N).ToString(); 
            }
            else
            {
                MessageBox.Show("Invalid number");
            }
        }
        private static long GetFactorial(int number)

        {

            if (number == 0)

            {

                return 1;

            }

            return number * GetFactorial(number - 1);

        }

        private void sayHiButton_Click(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);

        }
    }
}