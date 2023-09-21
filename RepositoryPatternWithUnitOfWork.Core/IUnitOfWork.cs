using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUnitOfWork.Core;
public interface IUnitOfWork:IDisposable
{
    //Add All Repositories here
    int Complete();
}
