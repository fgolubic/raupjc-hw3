using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoRepository;

namespace WebApplication.Models
{
    public class TodoViewModel
    {
      
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateDue { get; set; }
        public string Labels { get; set; }


        public TodoViewModel(TodoItem item)
        {
            Id = item.Id;
            Text = item.Text;
            DateCompleted = item.DateCompleted;
            DateDue = item.DateDue;
        }

        public TodoViewModel()
        {
        }

        public string DaysRemaining()
        {
            if (DateDue == null)
            {
                return " ";
            }

            else
            {
                return "za " + ((DateTime) DateDue - DateTime.Now).Days.ToString() + " dana!";
            }
        }
    }
}
