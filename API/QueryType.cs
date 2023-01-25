using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class QueryType
    {
     

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Car> GetCars([Service] DataContext context) => context.Cars;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<Car> GetCar([Service] DataContext context,int id)
        {
            return await context.Cars.FindAsync(id);
        }


    }
}
