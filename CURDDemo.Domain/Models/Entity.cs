using System;
using System.Collections.Generic;
using System.Text;

namespace CURDDemo.Domain.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime CreatedAt => DateTime.Now;
    }
}
