using Academia76721.Domain.Common;

namespace Academia76721.Domain.Entities
{
    public class Studio : BaseEntity<string>
    {
       

        public string Name { get; set; }
        public string Country  { get; set; }
        public IList<Movie> Portefolio { get; set; }
    }
}