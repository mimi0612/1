using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todo.Models
{
    public class todo
    {
        public int id { get; set; }
        public string Descriptinon { get; set; }
        public bool ok { get; set; }
        public virtual ApplicationUser User { get; set; }

        internal class Models
        {
            internal class ApplicationDbContext
            {
            }
        }
    }
}