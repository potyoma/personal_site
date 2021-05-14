using System.Threading.Tasks;

namespace Logic.CrudServices
{
    public interface IOwnerServices
    {
        Task<IEnumerable<OwnerModel>> GetAllOwnersAsync();
    }
}