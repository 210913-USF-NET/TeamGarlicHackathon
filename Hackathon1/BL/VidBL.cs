using DL;
using System;
using System.Collections.Generic;
using System.Linq;
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
        {
            int index = FindEquals(link);

            var cutlink = new StringBuilder();

            for(int i = index + 1; i < link.Length; i++)
            {
                cutlink.Append(link[i]);
            }
            string output = cutlink.ToString();
            return output;
        
        }
    }
}
