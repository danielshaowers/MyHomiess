using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomies.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; } //the ID of this class
        public String name { get; set; }
        public String category { get; set; }
        public String quality { get; set; }
        public String description { get; set; }
        public DateTime checkOutTime { get; set; } //0 if not checked out

        public Boolean CheckedOut { get; set; }
        
        public int maxTimeOut { get; set; } //max length of time until overdue

        public String condition { get; set; } //condition of item before check out

        public int lateFee { get; set; }
    }
}
