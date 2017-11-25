using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDemo1.Models
{
    [Table("tblDept")]
    public class Department
    {
        public int ID { get; set; }
        public string Name{get; set;}
        public List<Employee> Employees{ get; set; }

    }
}