using Academia76721.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Entities
{
    public class Director : Person
    {
        public Director()
        {
            this.Id = 0;
        }
        public string Description { get; set; }
        public IList<Movie> Movies { get; set; }
    }
}
