using MDTasks.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;

namespace MDTasks.Services
{
    public class DepartmentServices
    {
        private readonly IMongoCollection<Department> _department;
        public DepartmentServices(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("DbConnection"));
            IMongoDatabase database = client.GetDatabase("db_taskmanagement");
            _department = database.GetCollection<Department>("department");
        }

        public List<Department> Get()
        {
            return _department.Find(x => true).ToList();
        }

        public Department Get(string id)
        {
            return _department.Find(x => x.Id == id).FirstOrDefault();
        }
    }
}
