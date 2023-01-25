using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class MutationType
    {
        public async Task<Car> SaveCarAsync([Service] DataContext context,Car newCar)
        {
            context.Cars.Add(newCar);
            await context.SaveChangesAsync();
            return newCar;
        }

        public async Task<Car> UpdateCarAsync([Service] DataContext context, Car updateCar)
        {
         
            context.Cars.Update(updateCar);
            await context.SaveChangesAsync();
            return updateCar;

        }

        public async Task<string> DeleteCarAsync([Service] DataContext context, int id)
        {
      
            var dbCar = await context.Cars.FindAsync(id);
            if (dbCar == null) return "Not Found";

            context.Cars.Remove(dbCar);
            await context.SaveChangesAsync();

            return "Deleted";
        }
    }
}
