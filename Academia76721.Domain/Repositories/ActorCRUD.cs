using Academia76721.Domain.Entities;
using Academia76721.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Repositories
{
    public class ActorCRUD : ICRUD<Actor, int>
    {

        private readonly IList<Actor> _actores = new List<Actor>();  
        
        public Actor Delete(int id)
        {
            _actores.RemoveAt(id);
            return null;
        }

        public Actor GetOne(int id)
        {
            var pesquisa = _actores[id];

            return pesquisa;
        }

        public Actor Insert(Actor item)
        {
            var pesquisa = _actores.First( z=>z.Id == item.Id );
            if (pesquisa == null)
            {
                _actores.Add(item);
            }
            return pesquisa;
        }

        public Actor Update(Actor item)
        {
            throw new NotImplementedException();
        }

        IList<Actor> ICRUD<Actor, int>.GetAll()
        {
            
            
                return _actores;
          
            
        }
    }
}
