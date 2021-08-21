using MuOnline.Infrastruture.Application.Core;
using System;
using System.Threading.Tasks;

namespace MuOnline.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MuContext _context;

        public UnitOfWork(MuContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            try
            {
                await _context.SaveChangesAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Dispose();
            }
        }

        private void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}