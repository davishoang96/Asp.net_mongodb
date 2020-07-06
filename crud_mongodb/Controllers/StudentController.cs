using System;
using System.Threading.Tasks;
using crud_mongodb.IRepository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace crud_mongodb.Controllers
{
    [Route("api/[controller]")]
    public class StudentController
    {
        
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public Task<string> Get()
        {
            return this.GetStudent();
        }

        private async Task<string> GetStudent()
        {
            var student = await _studentRepository.Get();

            return JsonConvert.SerializeObject(student);
        }

        [HttpGet]
        public Task<string> Get(string Id)
        {
            return this.GetStudentByID(Id);
        }

        private async Task<string> GetStudentByID(string id)
        {
            var student = await _studentRepository.Get(id) ?? new Student();

            return JsonConvert.SerializeObject(student);
        }

        [HttpPost]
        public async Task<string> Post([FromBody] Student student)
        {
            await _studentRepository.Add(student);
            return "";
        }

        [HttpPut("{id}")]
        public async Task<string> Put(string id, [FromBody] Student student)
        {
            if (string.IsNullOrEmpty(id))
            {
                return "Invalid id";
            }
            else
            {
                return await _studentRepository.Update(id, student);
            }
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return "Invalid id";
            }
            else
            {
                await _studentRepository.Remove(id);
                return "";
            }
        }

            
        
    }
}
