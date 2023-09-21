using RepositoryPatternWithUnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUnitOfWork.EF;
public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    //here all repose and inject it at ctor

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public int Complete()=> _context.SaveChanges();
    

    public void Dispose() =>_context.Dispose();
}
