using Academia76721.Domain.Entities;
using Academia76721.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Repositories
{
    public class DirectorCRUD : ICRUD<Director, int>
    {
        private readonly IList<Director> _diretores = new List<Director>();
        public Director Delete(int id)
        {
            _diretores.RemoveAt(id);
            return null;
        }

       

        public Director GetOne(int id)
        {
            var pesquisa = _diretores[id];

            return pesquisa;
        }

        public Director Insert(Director item)
        {
            var pesquisa = _diretores.First(z => z.Id == item.Id);
            if (pesquisa == null)
            {
                _diretores.Add(item);
            }
            return pesquisa;
        }

        public Director Update(Director item)
        {
            throw new NotImplementedException();
        }

        IList<Director> ICRUD<Director, int>.GetAll()
        {
            return _diretores;
        }
    }
}
