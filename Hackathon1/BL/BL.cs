using System;

namespace BL
{
    public class BL :IBL
    {

        private IRep _repo;

        public BL(IRep repo)
        {
            _repo = repo;
        }
    }
}
