using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Task<DeleteResult>
using MongoDB.Driver;

namespace crud_mongodb.IRepository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> Get();
        Task<Student> Get(string id);

        //CREATE
        Task Add(Student Student);

        //UPDATE
        Task<string> Update(string id, Student Student);

        //DELETE
        Task<DeleteResult> Remove(string id);
        Task<DeleteResult> RemoveAll();
            
    }
}
