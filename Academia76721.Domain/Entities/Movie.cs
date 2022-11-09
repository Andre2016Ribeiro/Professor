using Academia76721.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Entities
{
    public class Movie : BaseEntity<Guid>
    {

        // Guid Id
        public Movie()
            {
            this.Id = Guid.Empty;

            }
        public string Name { get; set; }

        public string Description { get; set; }

        public MovieType  MovieType { get; set; }

        public IList<Actor> Casting { get; set; }

        public Studio Studio { get; set; }



    }
}
