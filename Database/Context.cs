using Microsoft.EntityFrameworkCore;

namespace ProfileMVC.Database;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) :  base(options){}
    
}