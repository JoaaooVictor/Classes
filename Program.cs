using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração e instanciação do objeto
            Produto prod = new Produto();
            Cliente clie = new Cliente();
            Pedido ped = new Pedido();

            Console.WriteLine("------------------------------");
            Console.Write("Digite o código do produto: ");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite a descrição do produto: ");
            prod.setDescricao(Console.ReadLine());
            Console.Write("Digite o valor do produto: ");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite a categoria do produto: ");
            prod.setCategoria(Console.ReadLine());

            Console.WriteLine("------------------------------");
            Console.Write("Digite o nome do cliente: ");
            clie.setNome(Console.ReadLine());
            Console.Write("Digite o cpf do cliente: ");
            clie.setCpf(Console.ReadLine());
            Console.Write("Digite o Endereço do cliente: ");
            clie.setEndereco(Console.ReadLine());
            Console.Write("Digite a idade do cliente: ");
            clie.setIdade(Convert.ToInt32(Console.ReadLine()));
                     
            Console.WriteLine("-----------------------------------");
            Console.Write("Digite o numero do pedido: ");
            ped.setNumero(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite a quantidade do pedido: ");
            ped.setQuantidade(Convert.ToInt32(Console.ReadLine()));
            

            Console.WriteLine("Código do produto: " + prod.getCodigo() + "\nDescrição do produto : " + prod.getDescricao() + "\nCategoria do produto: " + prod.getCategoria() +
                "\nValor do produto: " + prod.getValor().ToString("C"));

            Console.WriteLine("----------------------------");
            Console.WriteLine("Nome do Cliente: " + clie.getNome() + "\nCPF: " + clie.getcpf() + "\nEndereço: " + clie.getEndereco() + "\nIdade do cliente: " + clie.getIdade()); ;

            Console.WriteLine("Numero do pedido: " + ped.getNumero() + "\nQuantidade de produtos: ");
            Console.WriteLine("Total do pedido: " + prod.getValor() * ped.getQuantidade());
            Console.ReadKey();
        }




















































































































































    }
}
