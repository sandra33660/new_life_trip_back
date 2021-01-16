using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Models
{
    public interface ITripRepository : IDisposable
    {
        Task<IEnumerable<Trip>> GetTrip(int pageSize, int pageNum);
        Task<Trip> GetTripById(int idTrip);
        Task<Trip> InsertTrip(string Details, string Title, DateTime StartDate, DateTime FinalDate, int Price, int NumberOfParticipants);
        Task<Trip> DeleteTrip(int idTrip);
        Task<Trip> UpdateTrip(int idTrip);
    }
}