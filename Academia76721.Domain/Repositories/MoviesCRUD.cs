using Academia76721.Domain.Entities;
using Academia76721.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Repositories
{
    internal class MoviesCRUD : ICRUD<Movie, Guid>
    {
        private readonly IList<Movie> _movies = new List<Movie>();
        Movie ICRUD<Movie, Guid>.Delete(Guid id)
        {
            _movies.RemoveAt(_movies.Equals(id));
            return null;
        }

        IList<Movie> ICRUD<Movie, Guid>.GetAll()
        {
            throw new NotImplementedException();
        }

        Movie ICRUD<Movie, Guid>.GetOne(Guid id)
        {
            var pesquisa = _movies.GetEnumerator();

            return pesquisa;
        }

        Movie ICRUD<Movie, Guid>.Insert(Movie item)
        {
            var pesquisa = _movies.First(z => z.Id == item.Id);
            if (pesquisa == null)
            {
                _movies.Add(item);
            }
            return pesquisa;
        }

        Movie ICRUD<Movie, Guid>.Update(Movie item)
        {
            throw new NotImplementedException();
        }
    }
}
