using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_CORE.Helpers
{
    public static class StringExtensions
    {

        public static string AddInput(this string texto)
        {
            return "p_" + texto;
        }
    }
}
