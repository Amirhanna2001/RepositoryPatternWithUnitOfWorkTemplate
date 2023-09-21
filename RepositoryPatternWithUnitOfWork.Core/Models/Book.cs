using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUnitOfWork.Core.Models;
public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int AuthId { get; set; }
    public Author Author { get; set; }
}
