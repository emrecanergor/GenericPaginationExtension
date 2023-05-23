using Common.Backend.Domain.VehicleProcess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Backend.Data.Repositories
{
    /// <summary>
    /// VehicleProcess repository interface
    /// </summary>
    public interface IVehicleProcessRepository
    { 
        /// <summary>
        /// Get all active VehicleProcess by filters
        /// </summary>
        /// <param name="limit">Page limit</param>
        /// <param name="offset">Page offset</param>
        /// <returns>VehicleProcess list model</returns>
        Task<IEnumerable<ListVehicleProcessResponseModel>> ListAsync(int limit, int offset);
    }
}
