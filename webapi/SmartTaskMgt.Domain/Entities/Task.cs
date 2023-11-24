using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTaskMgt.Domain.Entities
{
    public class Task
    {
        public Task()
        {
            
        }
        public Guid TaskId { get; set; }
        public string TaskName { get; set; }
    }
}
