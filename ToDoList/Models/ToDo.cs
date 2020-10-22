using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Attributes { get; set; }
        public string Priority { get; set; }

        public virtual ApplicationUser User { get; set; }
        public bool isDone { get; set; }
    }
}