using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student() {Id = 1, Name = "tome"},
            new Student() {id = 2, Name= "dos"},
            new Student() {id  3, Name  "tres"}
        };

        public static List<Student> Students { get => students; set => students = value; }

        public IEnumerable<Student> Get()
        {
            return Students;
        }

        public Student Get(int id)
        {
            return Students.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<string> GetStudentCourses(int id)
        {
            if (id == 1)
                return new List<String>() { "C#", "ASP.NET", "SQL-Server" };
            else if (id == 2)
                return new List<string>() { "Phyton", "Mangalore", "Oracle-Server" };
            else
                return new List<string>() { "Anything", "bootstrap", "SQL-WorkBench };     
        };
    }
}
