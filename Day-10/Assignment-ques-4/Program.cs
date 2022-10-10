using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_ass4
{
    public class People
    {
        public string book_name;
        public string student_name;
        public string teacher_name;


        public void info(string book, string teacher, string student)
        {
            this.book_name = book;
            Console.WriteLine("Book name : " + book_name);
            this.student_name = student;
            Console.WriteLine("student name : " + student_name);
            this.teacher_name = teacher;
            Console.WriteLine("Teacher name : " + teacher_name);
        }
    }
    public class students : People
    {
        public void take_book()
        {
            Console.WriteLine("Student can takes  books from Librarian");
        }
        public void give_attendance()
        {
            Console.WriteLine("Present Teacher(Sir/Ma'am)");
        }
        public void attend_class()
        {
            Console.WriteLine("I am attending class\n\n");
        }

    }
    public class Teachers : People
    {
        public void take_book(string book)
        {
            Console.WriteLine("Teachers can take books for more days then students from Librarian");
            info("Full Statck with C#", "Remika Ma'am", "Ankit Gupta");
        }
        public void take_a_atendance()
        {
            Console.WriteLine("Persent or absent");
        }
        public void give_class()
        {
            Console.WriteLine("I am taking class");
        }

    }
    public class Library : People
    {
        public void take_book(string book, bool attendence, string name)
        {
            Console.WriteLine("Librarian allot the book");
            info("Full Statck with C#", "Sanjana ma'am", "Ankit Gupta");
        }
        public void take_attendance(string name)
        {
            Console.WriteLine("Librarian is taking Attendance\n\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            students s = new students();

            s.take_book();
            s.info("Full Statck with C#", "Karishma Ma'am", "Ankit Gupta");
            s.give_attendance();
            s.attend_class();


            Teachers t = new Teachers();

            t.take_book("C# programming");

            t.take_a_atendance();
            t.give_class();

            Library l = new Library();

            l.take_book("Science", true, "Rohit");

            l.take_attendance("Student");

            Console.ReadKey();
        }
    }
}
