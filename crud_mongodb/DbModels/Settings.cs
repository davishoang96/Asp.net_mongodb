using System;
using Microsoft.Extensions.Configuration;
namespace crud_mongodb.DbModels
{
    public class Settings
    {
        public string ConnectionString;
        public string Database;
        public IConfigurationRoot iConfigurationRoot;

    }
}
