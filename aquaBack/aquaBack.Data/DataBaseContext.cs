using aquaBack.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace aquaBack.Data;

public class DataBaseContext : DbContext
{
    public DbSet<RequestOrderModel> RequestOrders => Set<RequestOrderModel>();
    
    public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options) { }
}