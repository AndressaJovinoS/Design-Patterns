using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Program
	{
		// O código do cliente cria um builder object, passa-o para o
		// director e, em seguida, inicia o processo de construção.
		// No final resultado é recuperado do object constructor
		static void Main(string[] args)
		{
			var director = new Director();
			var builder = new ConcreteBuilder();
			director.Builder = builder;

			Console.WriteLine("Standard basic product:");
			director.buildMinimalViableProduct();
			Console.WriteLine(builder.GetProduct().ListParts());

			Console.WriteLine("Standard full featured product:");
			director.buildFullFeaturedProduct();
			Console.WriteLine(builder.GetProduct().ListParts());

			// O Builder pattern pode ser usado sem uma classe Director
			Console.WriteLine("Custom product:");
			builder.BuildPartA();
			builder.BuildPartC();
			Console.Write(builder.GetProduct().ListParts());

			Console.ReadKey();
		}
	}
}
