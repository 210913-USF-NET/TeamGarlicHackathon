using System;

namespace DL
{
    public class DBRepo : IRepo
    {
        private HackDBContext _context;
        public DBRepo(HackDBContext context)
        {
            _context = context;
        }
    }
}
