using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
