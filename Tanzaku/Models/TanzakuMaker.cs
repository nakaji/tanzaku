using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using WebGrease.Css.Extensions;

namespace Tanzaku.Models
{
    public class TanzakuMaker
    {
        public string Generate(string text)
        {
            var sb=new StringBuilder();
            sb.AppendLine("┏┻┓");

            var vartString = new Regex("(.)").Replace(text, "┃$1┃\r\n");
            sb.Append(vartString);

            sb.AppendLine("┗━┛");
            return sb.ToString();
        }
    }
}