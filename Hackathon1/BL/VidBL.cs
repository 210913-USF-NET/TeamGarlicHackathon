using DL;
using Models;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> 572da0654e57c53c8ad7bbefe42c836e6d0a3f29
using System.Text;

namespace BL
{
    public class VidBL :IBL
    {

        private IRepo _repo;

        public VidBL(IRepo repo)
        {
            _repo = repo;
        }

        public List<ModelVideo> GetVideos()
        {
            return _repo.GetVideos();
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

<<<<<<< HEAD
           public int FindEquals(string link)
        {
            
           for(int i = 0; i < link.Length; i++)
           {
               if(link[i] == '=')
               {
                   return i;
               }
           }
           System.Console.WriteLine("invalid link");
           return -1;
        }

          public string GetId(string link)
=======
        public int FindEquals(string link)
        {

            for (int i = 0; i < link.Length; i++)
            {
                if (link[i] == '=')
                {
                    return i;
                }
            }
            System.Console.WriteLine("invalid link");
            return -1;
        }

        public string GetId(string link)
>>>>>>> 572da0654e57c53c8ad7bbefe42c836e6d0a3f29
        {
            int index = FindEquals(link);

            var cutlink = new StringBuilder();

<<<<<<< HEAD
            for(int i = index + 1; i < link.Length; i++)
=======
            for (int i = index + 1; i < link.Length; i++)
>>>>>>> 572da0654e57c53c8ad7bbefe42c836e6d0a3f29
            {
                cutlink.Append(link[i]);
            }
            string output = cutlink.ToString();
            return output;
<<<<<<< HEAD
        
=======

>>>>>>> 572da0654e57c53c8ad7bbefe42c836e6d0a3f29
        }
    }
}
