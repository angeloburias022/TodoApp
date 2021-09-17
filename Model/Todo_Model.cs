using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Model
{
    public class Todo_Model
    {
        public int TodoID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string When_Todo { get; set; }
        public string Task_Status { get; set; }
        public byte TodoDate { get; set; }
    }
}
