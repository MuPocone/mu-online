using System.Threading.Tasks;

namespace MuOnline.Infrastruture.Application.Core
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}