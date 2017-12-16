using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class StudentsV1Controller : ApiController
    {
        static List<StudentV1> students = new List<StudentV1>()
        {
            new StudentV1() {Id = 1, Name = "Jose"},
            new StudentV1() {Id = 2, Name = "Lucho"},
            new StudentV1() {Id = 3, Name = "Riki"},
        };

        [Route("api/v1/students")]
        public IEnumerable<StudentV1> Get()
        {
            return students;
        }

        [Route("api/v1/students/{id}")]
        public StudentV1 Get(int id)
        {
                return students.FirstOrDefault(s => s.Id == id);
          
        }
    }
}

