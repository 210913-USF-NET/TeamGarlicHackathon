using DL;
using System;
using System.Collections.Generic;

namespace BL
{
    public class VidBL :IBL
    {

        private IRepo _repo;

        public VidBL(IRepo repo)
        {
            _repo = repo;
        }

            public string RandomString(List<string> strings)
        {
            Console.WriteLine("seeding rng");
            Random rng = new Random();
            System.Console.WriteLine("rng seeded");
            int min = 0;
            int max = strings.Count;
            //minimum is inclusive, maximum is exclusive
            System.Console.WriteLine("generating index");
            int RandomIndex = rng.Next(min, max);
            
            bool isvalid;
            do 
            {
                isvalid = true;
                if(RandomIndex < 0 || RandomIndex >= strings.Count)
                {
                    isvalid = false;
                    RandomIndex = rng.Next(min, max);

                }
            } while (!isvalid);
           

            return strings[RandomIndex];
        }
    }
}
