using Ap204_Pronia.DAL;
using Microsoft.EntityFrameworkCore;
using Pronia.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Setting> GetDatas()
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync();
            return setting;
        }

    }
}
