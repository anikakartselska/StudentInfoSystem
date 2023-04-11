using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;

namespace UserLogin
{
    public class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
           // LogsContext context = new LogsContext();
            string activityLine = DateTime.Now + ";"
                                               + LoginValidation.CurrentUsername + ";" +
                                               LoginValidation.CurrentUserRole + ";" + activity;
            if (File.Exists("test.txt"))
            {
                File.AppendAllText("test.txt", activityLine);
            }

        //    context.Logs.Add(new Logs(activityLine));
       //     context.SaveChanges();

            currentSessionActivities.Add(activityLine);
        }

        public static IEnumerable<Logs> GetCurrentSessionActivities(string filter)
        {   LogsContext context = new LogsContext();
            // return (from activity in currentSessionActivities
            //     where activity.Contains(filter)
            //     select activity).ToList();
            return (from activity in context.Logs
                 where activity.Text.Contains(filter)
                 select activity).ToList();
        }
    }
}