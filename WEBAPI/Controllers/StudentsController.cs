using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Jose"},
            new Student() {Id = 1, Name = "Lucho"},
            new Student() {Id = 1, Name = "Riki"},
        };
        [Route("~/api/teachers")]
        public IEnumerable<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher(){ Id=1, Name = "Rob" },
                new Teacher(){ Id=2, Name = "Robin" },
                new Teacher(){ Id=3, Name = "Rick" }
            };

            return teachers;
        }

        [Route("")]
        public IEnumerable<Student> Get()
        {
            return students;
        }
        [Route("{id}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        [Route("{id}/courses")]
        public IEnumerable<string> GetStudentCourses(int id)
        {
            if (id == 1)
                return new List<String>() { "C#", "ASP.NET", "SQL-Server" };
            else if (id == 2)
                return new List<String>() { "Phyton", "Mangalore", "Oracle-Server" };
            else
                return new List<String>() { "Anything", "bootstrap", "SQL-WorkBench" };
        }
    }
}
