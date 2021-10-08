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
    }
}
