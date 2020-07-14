using Microsoft.EntityFrameworkCore;

namespace FashiShop.Core.DAL.EntityFramework
{
    public class EFSingletionContext<TContext>
    where TContext:DbContext, new()
    {
        private static  TContext _context;
        public static TContext Instance{
            get{
                if(_context == null)
                {
                    _context= new TContext();
                }
                return _context;
            }
        }
    }
}