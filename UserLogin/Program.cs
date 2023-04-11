using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;

namespace UserLogin
{
    internal class Program
    {
        static void PrintError(string msg)
        {
            Console.WriteLine("!!! " + msg + " !!!");
        }

        public static IEnumerable<string> readFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            IEnumerable<string> fileRows = new List<string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                fileRows.Append(line);
            }

            return fileRows;
        }

        public static void menu()
        {
            Int32 option;
            Console.WriteLine(
                "Choose an option:\n0:Exit\n1:Change role\n2:Change activeTo:\n3:Show all users:\n4:Read log file:\nRead current activities");
            while (true)
            {
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0: return;
                    case 1:
                    {
                        DoActionBasedOnRoleRights(() =>
                            {
                                Console.WriteLine("Input username:");
                                String username = Console.ReadLine();
                                Console.WriteLine("Input role:");
                                Console.WriteLine(
                                    "Input role: \n 0 - ANONYMOUS,\n 1 - ADMIN,\n 2 - INSPECTOR,\n 3 - PROFESSOR,\n 4 - STUDENT");
                                Int32 roleInInteger = Int32.Parse(Console.ReadLine());
                                UserRoles role;
                                switch (roleInInteger)
                                {
                                    case 1:
                                        role = UserRoles.ADMIN;
                                        break;
                                    case 2:
                                        role = UserRoles.INSPECTOR;
                                        break;
                                    case 3:
                                        role = UserRoles.INSPECTOR;
                                        break;
                                    case 4:
                                        role = UserRoles.STUDENT;
                                        break;
                                    default:
                                        role = UserRoles.ANONYMOUS;
                                        break;
                                }

                                UserData.AssignUserRole(username, role);
                            },
                            RoleRight.EDIT_USER);
                        break;
                    }
                    case 2:
                    {
                        DoActionBasedOnRoleRights(() =>
                            {
                                Console.WriteLine("Input username:");
                                String username = Console.ReadLine();
                                Console.WriteLine("Input date:");
                                DateTime date = Convert.ToDateTime(Console.ReadLine());
                                UserData.SetUserActiveTo(username, date);
                            },
                            RoleRight.EDIT_USER
                        );
                        break;
                    }

                    case 3:
                    {
                        DoActionBasedOnRoleRights((() => Console.WriteLine("Users....")), RoleRight.VIEW_ALL_USERS);
                        break;
                    }
                    case 4:
                        DoActionBasedOnRoleRights(() =>
                        {
                            foreach (string row in readFile("test.txt"))
                            {
                                Console.WriteLine(row);
                            }
                        }, RoleRight.EDIT_USER);
                        break;
                    case 5:
                    {
                        DoActionBasedOnRoleRights(() =>
                        {
                            StringBuilder sb = new StringBuilder();
                            Console.WriteLine("Write a filter for the activities:");
                            IEnumerable<Logs> currentActs =
                                Logger.GetCurrentSessionActivities(Console.ReadLine());
                            foreach (Logs line in currentActs)
                            {
                                sb.Append(line.Text);
                            }

                            Console.WriteLine(sb.ToString());
                        }, RoleRight.VIEW_LOGS);
                        break;
                    }
                    default:
                    {
                        return;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            // DateTime date = new DateTime(2017, 9, 15, 10, 30, 0);
            // Console.WriteLine(date.Hour);
            // DateTime todayDate = DateTime.Today;
            // Console.WriteLine(todayDate.Hour);
            // int nextyear = todayDate.AddYears(1).Year;
            // DateTime firstnextyear = new DateTime(nextyear, 1, 1);
            // Console.WriteLine(todayDate.AddHours(12).Date);

            // Console.WriteLine("Input date:");
            // string date = Console.ReadLine();
            // Console.WriteLine(Convert.ToDateTime(date));

            // User user = new User("anika", "parola", "121220100", UserRoles.ADMIN);
            var list = UserData.TestUser1;
            Console.WriteLine("Input username:");
            String username = Console.ReadLine();
            Console.WriteLine("Input password:");
            String password = Console.ReadLine();
            LoginValidation loginValidation = new LoginValidation(username, password, PrintError);

            User newUser = new User();
            if (loginValidation.ValidateUserInput(ref newUser))
            {
                Console.WriteLine(newUser);
            }

            menu();
        }

        static void DoActionBasedOnRoleRights(Action func, RoleRight roleRight)
        {
            if (RightsGranted.RoleToRightsMap[LoginValidation.CurrentUserRole]
                .Contains(roleRight))
            {
                func();
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
    }
}