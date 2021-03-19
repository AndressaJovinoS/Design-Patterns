using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Faz sentido usar o Builder pattern apenas quando seus produtos são
    // bastante complexo e requer configuração extensiva.
    //
    // Ao contrário de outros padrões de criação (creational patterns), diferentes de concrete builders
    // podem produz produtos não relacionados.
    // Em outras palavras, resultados de vários construtores nem sempre pode seguir a mesma interface.
    class Product
	{
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}
