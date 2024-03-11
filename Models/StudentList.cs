using System.Net;

namespace Task1_Day1.Models
{
    public class StudentList
    {
        public static List<Student> Students { get; set; }

        static StudentList()
        {
            Students = new List<Student>();
            Students.Add(new Student() { Id = 1 , Name = "Rahma" , Address= "Damietta" ,Image = "1.jpg"});
            Students.Add(new Student() { Id = 2, Name = "Hassan", Address = "Aswan", Image = "2.jpg" });
            Students.Add(new Student() { Id = 3, Name = "Hanan", Address = "Minia" , Image = "3.jpg" });
            

        }
    }
}
