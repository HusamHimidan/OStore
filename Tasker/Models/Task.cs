using System;

namespace Tasker.Models
{
    public class Task
    {
        public Task()
        {
            Date = DateTime.Now;
        }
        public string Note { get; set; }
        public bool IsFinished { get; set; }
        public DateTime Date { get; set; }
    }
}
