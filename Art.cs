using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L14_Image
{
    public class Art
    {
        // Enumerables
        // Keyword: enum
        public enum STYLE { Abstract, Impressionism, Cubism }

        STYLE _style;
        string _name;

        public STYLE Style { get => _style; set => _style = value; }
        public string Name { get => _name; set => _name = value; }

        public Art(string name , STYLE style)
        {
            _name = name;
            _style = style;

            
        }

        public override string ToString()
        {
            return $"{_name} - {_style}";
        }
    } // Art


} // namespace
