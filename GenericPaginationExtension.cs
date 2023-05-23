using Common.Backend.Data.Entity.Base;
using Common.Backend.Data.Entity.Types;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Backend.Data.Extensions
{
    public static class GenericPaginationExtension
    {
        public static async Task<List<T>> Pagination<T>(this DbSet<T> model, int limit, int offset) where T : BaseEntity
        {
            List<T> result = new();
            if (limit > 0 && offset > 0)      //normal pagination
                result = await model
                                .AsNoTracking()
                                .Where(w => w.Status != StatusType.Deleted)
                                .Skip(offset)
                                .Take(limit)
                                .ToListAsync();
            else if (limit > 0 && offset < 1) //fetch data before limit
                result = await model
                                .AsNoTracking()
                                .Where(w => w.Status != StatusType.Deleted)
                                .Take(limit)
                                .ToListAsync();
            else if (limit < 1 && offset > 0) //fetch data after offset
                result = await model
                                .AsNoTracking()
                                .Where(w => w.Status != StatusType.Deleted)
                                .Skip(offset)
                                .ToListAsync();
            else                             //fetch all data
                result = await model
                                .AsNoTracking()
                                .Where(w => w.Status != StatusType.Deleted)
                                .ToListAsync();
            return result;
        }
    }
}
