using Rawaa_Api.Models;
using Rawaa_Api.Services.Interfaces;

namespace Rawaa_Api.Services
{
    public class RestaurantData : IProvider<Restaurant>
    {
        private RawaaDBContext context;
        public RestaurantData()
        {
            context = new RawaaDBContext();
            //context = _context;
        }
        public Restaurant Add(Restaurant entity)
        {
            var result = context.Add(entity);
            context.SaveChanges();

            //int id = entity.Id;
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Restaurant Find(int id)
        {
            return new Restaurant() { NameAr = "first rrrrrrrrrrr" };
        }

        public IList<Restaurant> List()
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Restaurant entity)
        {
            throw new NotImplementedException();
        }
    }
}
