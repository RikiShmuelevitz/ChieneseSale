using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int ClasssId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        public string Password { get; set; }
        public double StudentAmount { get; set; }


    }
}
