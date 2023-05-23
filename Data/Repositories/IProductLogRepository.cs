using Common.Backend.Domain.ProductLog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Backend.Data.Repositories
{
    /// <summary>
    /// ProductLog repository interface
    /// </summary>
    public interface IProductLogRepository
    {
        /// <summary>
        /// Get all active ProductLog by filters
        /// </summary>
        /// <param name="limit">Page limit</param>
        /// <param name="offset">Page offset</param>
        /// <returns>ProductLog list model</returns>
        Task<IEnumerable<ListProductLogResponseModel>> ListAsync(int limit, int offset);
    }
}
