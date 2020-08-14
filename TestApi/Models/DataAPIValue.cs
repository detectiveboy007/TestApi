using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class DataAPIValue
    {
        [Key]
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
        
    }
}
