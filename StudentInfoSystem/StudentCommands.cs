using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using MinimalMVVM.ViewModel;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentCommands : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<string> StudStatusChoices { get; set; }
        private Student myStudent;
        private BitmapImage studentImage;

        public BitmapImage StudentImage
        {
            get => studentImage;
            set
            {
                if (value != studentImage)
                {
                    studentImage = value;
                    OnPropertyChanged("StudentImage");
                }
            }
        }

        public Student MyStudent
        {
            get => myStudent;
            set
            {
                if (value != myStudent)
                {
                    myStudent = value;
                    OnPropertyChanged("MyStudent");
                }
            }
        }

        private Grid studentGrid;
        private Grid userGrid;

        public Grid StudentGrid
        {
            get => studentGrid;
            set
            {
                if (value != StudentGrid)
                {
                    StudentGrid = value;
                    OnPropertyChanged("StudentGrid");
                }
            }
        }

        public Grid UserGrid
        {
            get => userGrid;
            set
            {
                if (value != UserGrid)
                {
                    UserGrid = value;
                    OnPropertyChanged("UserGrid");
                }
            }
        }


        public StudentCommands(User data) : this()
        {
            StudentValidator studentValidator = new StudentValidator();
            this.myStudent = studentValidator.GetStudentDataByUser(data);
            // this.DataContext = myStudent;
        }


        public StudentCommands()
        {
            // InitializeComponent();
            FillStudStatusChoices();
        }

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
                       SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery = @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    // comboBoxStatus.Items.Add(s);
                    notEndOfResult = reader.Read();
                }
            }

            Console.WriteLine(StudStatusChoices);
        }


        public new ICommand Button_Click => new DelegateCommand(Clear);

        public new ICommand insertPicture_Click => new DelegateCommand(() =>
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                        "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                        "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                var imageBytes = File.ReadAllBytes(op.FileName);
                MyStudent.Image = imageBytes;
                 OnPropertyChanged("MyStudent");
                StudentInfoContext context = new StudentInfoContext();
                Student updateStudent = context.Students.First(student => student.StudentId == MyStudent.StudentId);
                updateStudent.Image = MyStudent.Image;
                context.SaveChanges();
            }
        });

        private void Clear()
        {
            foreach (var x in studentGrid.Children)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

            foreach (var x in userGrid.Children)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

            MyStudent.Status1 = null;
        }

        public new ICommand Button_Click_1 => new DelegateCommand(() =>
        {
            studentGrid.IsEnabled = !studentGrid.IsEnabled;
            UserGrid.IsEnabled = !UserGrid.IsEnabled;
        });

        public new ICommand Button_Click_2 => new DelegateCommand(() =>
        {
            Student student = StudentData.TestStudents1.First();
            myStudent.Ime1 = student.Ime;
            myStudent.Prezime1 = student.Prezime;
            myStudent.Familia1 = student.Familia;
            myStudent.Faklutet1 = student.Faklutet;
            myStudent.Specialnost1 = student.Specialnost;
            myStudent.ObrazovatelnoKvalifikacionnaStepen1 = student.ObrazovatelnoKvalifikacionnaStepen;
            myStudent.Status1 = student.Status;
            myStudent.FaklutetenNomer1 = student.FaklutetenNomer;
            myStudent.Kurs1 = student.Kurs;
            myStudent.Potok1 = student.Potok;
            myStudent.Grupa1 = student.Grupa;
            OnPropertyChanged("MyStudent");
        });

        public new ICommand Button_Click_3 => new DelegateCommand(() =>
        {
            bool completed = true;
            int kurss;
            int potokk;
            int groupp;
            Student student = null;
            foreach (var x in studentGrid.Children)
            {
                if (x is TextBox && ((TextBox)x).Text == String.Empty)
                {
                    completed = false;
                    break;
                }
            }

            foreach (var x in userGrid.Children)
            {
                if (x is TextBox && ((TextBox)x).Text == String.Empty)
                {
                    completed = false;
                    break;
                }
            }

            if (completed == false)
            {
                MessageBox.Show("Your form is not completed");
            }
            else
            {
                student = new Student(
                    MyStudent.Ime,
                    MyStudent.Prezime,
                    MyStudent.Familia1,
                    MyStudent.Faklutet,
                    MyStudent.Specialnost,
                    MyStudent.ObrazovatelnoKvalifikacionnaStepen,
                    MyStudent.Status1,
                    MyStudent.FaklutetenNomer1,
                    MyStudent.Kurs1,
                    MyStudent.Potok1,
                    MyStudent.Grupa1);
            }

            if (student == null)
            {
                MessageBox.Show("There were some errors while creating user");
            }
        });

        public new ICommand LogOut_Click => new DelegateCommand(() =>
        {
            Clear();
            studentGrid.IsEnabled = false;
            userGrid.IsEnabled = false;
        });

        private bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();
            return countStudents == 0;
        }

        private void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in StudentData.TestStudents1)
            {
                context.Students.Add(st);
            }

            context.SaveChanges();
        }

        public new ICommand Button_Click_4 => new DelegateCommand(() =>
        {
            MessageBox.Show(TestStudentsIfEmpty().ToString());
        });


        public new ICommand Button_Click_6 => new DelegateCommand(() =>
        {
            if (TestStudentsIfEmpty())
            {
                CopyTestStudents();
            }
        });
    }
}