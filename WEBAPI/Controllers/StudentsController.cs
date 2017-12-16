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
            new Student() {Id = 1, Name = "Jose"},
            new Student() {Id = 2, Name = "Lucho"},
            new Student() {Id = 3, Name = "Riki"},
        };

        public IHttpActionResult Get()
        {
            return Ok(students);
        }

        public IHttpActionResult Get(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return Content(HttpStatusCode.NotFound, "student not founded");
            }
            return Ok(student);
        }
    }
          
}
