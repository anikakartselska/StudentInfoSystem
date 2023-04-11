using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // public List<string> StudStatusChoices { get; set; }

        public MainWindow(User data):this()
        {
            // StudentValidator studentValidator = new StudentValidator();
            // Student myStudent = studentValidator.GetStudentDataByUser(data);
            DataContext = new StudentCommands(data);
        }


        public MainWindow()
        {
            InitializeComponent();
            // DataContext = new Stude;
        }

        // private void insertPicture_Click(object sender, RoutedEventArgs e)
        // {
        //     OpenFileDialog op = new OpenFileDialog();  
        //     op.Title = "Select a picture";  
        //     op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +  
        //                 "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +  
        //                 "Portable Network Graphic (*.png)|*.png";  
        //     if (op.ShowDialog() == true)  
        //     {  
        //         Image.Source = new BitmapImage(new Uri(op.FileName));  
        //         
        //     }  
        // }

       
        //     private void FillStudStatusChoices()
        //     {
        //         StudStatusChoices = new List<string>();
        //         using (IDbConnection connection = new
        //                    SqlConnection(Properties.Settings.Default.DbConnect))
        //         {
        //             string sqlquery = @"SELECT StatusDescr FROM StudStatus";
        //             IDbCommand command = new SqlCommand();
        //             command.Connection = connection;
        //             connection.Open();
        //             command.CommandText = sqlquery;
        //             IDataReader reader = command.ExecuteReader();
        //             bool notEndOfResult;
        //             notEndOfResult = reader.Read();
        //             while (notEndOfResult)
        //             {
        //                 string s = reader.GetString(0);
        //                 StudStatusChoices.Add(s);
        //                 comboBoxStatus.Items.Add(s);
        //                 notEndOfResult = reader.Read();
        //             }
        //         }
        //
        //         Console.WriteLine(StudStatusChoices);
        //     }
        //
        //
        //     private void Button_Click(object sender, RoutedEventArgs e)
        //     {
        //         Clear();
        //     }
        //
        //     private void Clear()
        //     {
        //         foreach (var x in studentGrid.Children)
        //         {
        //             if (x is TextBox)
        //             {
        //                 ((TextBox)x).Text = String.Empty;
        //             }
        //         }
        //
        //         foreach (var x in userGrid.Children)
        //         {
        //             if (x is TextBox)
        //             {
        //                 ((TextBox)x).Text = String.Empty;
        //             }
        //         }
        //
        //         comboBoxStatus.SelectedItem = null;
        //     }
        //
        //     private void Button_Click_1(object sender, RoutedEventArgs e)
        //     {
        //         studentGrid.IsEnabled = !studentGrid.IsEnabled;
        //         userGrid.IsEnabled = !userGrid.IsEnabled;
        //     }
        //
        //     private void Button_Click_2(object sender, RoutedEventArgs e)
        //     {
        //         Student myStudent = StudentData.TestStudents1.First();
        //         Ime.Text = myStudent.Ime;
        //         Prezime.Text = myStudent.Prezime;
        //         Familiq.Text = myStudent.Familia;
        //         Falkutet.Text = myStudent.Faklutet;
        //         Specialnost.Text = myStudent.Specialnost;
        //         OKS.Text = myStudent.ObrazovatelnoKvalifikacionnaStepen;
        //         comboBoxStatus.SelectedItem = myStudent.Status;
        //         FakNomer.Text = myStudent.FaklutetenNomer;
        //         Kurs.Text = myStudent.Kurs.ToString();
        //         Potok.Text = myStudent.Potok.ToString();
        //         Grupa.Text = myStudent.Grupa.ToString();
        //     }
        //
        //     private void Button_Click_3(object sender, RoutedEventArgs e)
        //     {
        //         bool completed = true;
        //         int kurss;
        //         int potokk;
        //         int groupp;
        //         Student student = null;
        //         foreach (var x in studentGrid.Children)
        //         {
        //             if (x is TextBox && ((TextBox)x).Text == String.Empty)
        //             {
        //                 completed = false;
        //                 break;
        //             }
        //         }
        //
        //         foreach (var x in userGrid.Children)
        //         {
        //             if (x is TextBox && ((TextBox)x).Text == String.Empty)
        //             {
        //                 completed = false;
        //                 break;
        //             }
        //         }
        //
        //         if (completed == false)
        //         {
        //             MessageBox.Show("Your form is not completed");
        //         }
        //         else if (!int.TryParse(Kurs.Text, out kurss))
        //         {
        //             MessageBox.Show("The Kurs should be number");
        //         }
        //
        //         else if (!int.TryParse(Potok.Text, out potokk))
        //         {
        //             MessageBox.Show("The Potok should be number");
        //         }
        //
        //         else if (!int.TryParse(Grupa.Text, out groupp))
        //         {
        //             MessageBox.Show("The Grupa should be number");
        //         }
        //         else
        //         {
        //             student = new Student(
        //                 Ime.Text,
        //                 Prezime.Text,
        //                 Familiq.Text,
        //                 Falkutet.Text,
        //                 Specialnost.Text,
        //                 OKS.Text,
        //                 comboBoxStatus.SelectedItem.ToString(),
        //                 FakNomer.Text,
        //                 kurss,
        //                 potokk,
        //                 groupp);
        //         }
        //
        //         if (student == null)
        //         {
        //             MessageBox.Show("There were some errors while creating user");
        //         }
        //     }
        //
        //     private void LogOut_Click(object sender, RoutedEventArgs e)
        //     {
        //         Clear();
        //         studentGrid.IsEnabled = false;
        //         userGrid.IsEnabled = false;
        //     }
        //
        //     private bool TestStudentsIfEmpty()
        //     {
        //         StudentInfoContext context = new StudentInfoContext();
        //         IEnumerable<Student> queryStudents = context.Students;
        //         int countStudents = queryStudents.Count();
        //         return countStudents == 0;
        //     }
        //
        //     private void CopyTestStudents()
        //     {
        //         StudentInfoContext context = new StudentInfoContext();
        //         foreach (Student st in StudentData.TestStudents1)
        //         {
        //             context.Students.Add(st);
        //         }
        //         context.SaveChanges();
        //
        //     }
        //
        //     private void Button_Click_4(object sender, RoutedEventArgs e)
        //     {
        //         MessageBox.Show(TestStudentsIfEmpty().ToString());
        //     }
        //
        //   
        //     private void Button_Click_6(object sender, RoutedEventArgs e)
        //     {
        //         if (TestStudentsIfEmpty())
        //         { CopyTestStudents(); }
        //
        //     }
        //  
        //
    }
}