using System.Collections.Generic;
using System.Linq;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidator
    {
        public Student GetStudentDataByUser(User user)
        {
            StudentInfoContext context = new StudentInfoContext();
            if (user.FakNum1 == null) return null;

            List<Student> Students = (from student in context.Students
                where student.FaklutetenNomer1.Equals(user.FakNum1)
                select student).ToList();


            if (Students.Count > 0)
            {
                return Students.First();
            }

            return null;
        }
    }
}