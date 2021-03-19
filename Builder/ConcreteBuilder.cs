using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	// As classes do Concrete Builder seguem a interface do Builder e fornecem
	// implementações específicas das etapas de construção. Seu programa pode ter
    // diversas variações de Builders, implementadas de forma diferente.
	class ConcreteBuilder : IBuilder
	{
        private Product _product = new Product();

        // Uma nova instância do construtor deve conter um objeto de produto em branco, que
        // é usado na montagem posterior.
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // Todas as etapas de produção funcionam com a mesma instância do produto.

        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }

        // Os construtores de Concrete devem fornecer seus próprios métodos para
        // recuperando resultados. Isso porque vários tipos de construtores podem
        // criar produtos totalmente diferentes que não seguem o mesmo
        // interface. Portanto, tais métodos não podem ser declarados na base
        // Interface do construtor (pelo menos em uma programação estaticamente tipada
        // língua).
        //
        // Normalmente, após retornar o resultado final ao cliente, um construtor
        // espera-se que a instância esteja pronta para começar a produzir outro produto.
        // É por isso que é uma prática comum chamar o método de redefinição no final
        // do corpo do método `GetProduct`. No entanto, este comportamento não é
        // obrigatório, e você pode fazer seus construtores esperarem por uma redefinição explícita
        // chame do código do cliente antes de descartar o resultado anterior.

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
