using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentInfoSystem
{
    static class StudentData
    {
        private static List<Student> TestStudents = new List<Student>
        {
            new Student("Ime",
                "Prezime",
                "Familia",
                "Faklutet",
                "Specialnost",
                "ObrazovatelnoKvalifikacionnaStepen",
                "Status",
                "121220100", 1, 1, 2)
        };

        public static List<Student> TestStudents1 => TestStudents;

        public static Student IsThereStudent(String facNum)
        {
            StudentInfoContext context =
                new StudentInfoContext();
            Student result =
                (from st in context.Students
                    where st.FaklutetenNomer == facNum
                    select st).First();
            return result;
        }
        public static Student deleteStudentByFakultyNumber(String facNum)
        {
            StudentInfoContext context =
                new StudentInfoContext();
            Student result =
                (from st in context.Students
                    where st.FaklutetenNomer == facNum
                    select st).First();
            context.Students.Remove(result);
            context.SaveChanges();
            return result;
        }
    }
}