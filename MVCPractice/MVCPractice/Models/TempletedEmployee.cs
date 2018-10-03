using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCPractice.Models
{
    public class TempletedEmployee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}