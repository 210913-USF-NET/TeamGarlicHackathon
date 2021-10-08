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


        List<ModelVideo> GetVideos();
    }
}
