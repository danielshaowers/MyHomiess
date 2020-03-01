using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomies.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; } //this doesn't really matter, it just needs to exist
        public String caseID { get; set; }


        public Boolean checkedOut { get; set; } //whether the user already has something checked out

        [DataType(DataType.DateTime)]  //a data annotation

        public DateTime checkOutDate { get; set; }
    }
}
