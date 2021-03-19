using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	// A interface do Builder especifica métodos
	//para criar as diferentes partes of the Product objects.
	interface IBuilder
	{
		void BuildPartA();
		void BuildPartB();
		void BuildPartC();
	}
}
