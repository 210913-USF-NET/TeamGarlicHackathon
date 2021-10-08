using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        /// <summary>
        /// Takes in a list of strings and returns a random string from the list
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        string RandomString(List<string> strings);

<<<<<<< HEAD
        /// <summary>
        /// Takes in a string and returns the index of "="
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        int FindEquals(string link);

        /// <summary>
        /// Takes in a string and returns a new string of everything after "=". Calls FindEquals(link)
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        string GetId(string link);
=======

        List<ModelVideo> GetVideos();
        string GetId(string link);
        int FindEquals(string link);
>>>>>>> 572da0654e57c53c8ad7bbefe42c836e6d0a3f29
    }
}
