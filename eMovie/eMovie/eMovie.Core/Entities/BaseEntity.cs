using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Core.Entities
{
    public class BaseEntity
    {
        public int id { get; set; }
        public DateTime DateCreated { get; set; }
        public BaseEntity()
        {
            DateCreated = DateTime.Now;
        }
    }
}
