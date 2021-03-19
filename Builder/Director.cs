using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	// The Director é apenas responsável por executar as etapas de construção em um
	// sequência particular. É útil ao produzir produtos de acordo com um
	// pedido ou configuração específica. Estritamente falando, a classe Director é
	// opcional, já que o cliente pode controlar os construtores diretamente.
	class Director
	{
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director pode construir várias variações de produto usando o mesmo
        // etapas de construção. building steps
        public void buildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void buildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
