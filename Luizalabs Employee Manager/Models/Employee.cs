using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Luisalabs_Employee_Manager.Models
{
    public class Employee
    {
        [JsonIgnore]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}