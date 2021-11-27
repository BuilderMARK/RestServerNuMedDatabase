using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database4Adult1.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Database4Adult1.Domain
{
    public class AdultRepo : IAdultRepo
    {
        
        protected AdultContext ctx;


        public AdultRepo(AdultContext ctx)
        {
            this.ctx = ctx;
        }
        
        
        public async Task<IList<Adult>> ReadAllAdults()
        {
            List<Adult> adults = ctx.Adults.ToList();
                return adults;
        }

        public async Task<Adult> AddAdult(Adult addAdult)
        {
            await ctx.Adults.AddAsync(addAdult);
            await ctx.SaveChangesAsync();
            return addAdult;
        }

        public async Task<Adult> UpdateAdult(Adult updateAdult)
        {
            ctx.Update(updateAdult);
            await ctx.SaveChangesAsync();
            return updateAdult;
        }

        public async Task DeleteAdult(int deleteAdult)
        {
            Adult firstAsync = await ctx.Adults.FirstOrDefaultAsync(adult => adult.id == deleteAdult );
            ctx.Remove(firstAsync);
            await ctx.SaveChangesAsync();
        }
    }
}