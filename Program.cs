using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            veiculo v = new veiculo { proprietario = new Proprietario { endereco = new Endereco { } } };
            Boolean exit = true;
            do
            {
    
                int menu = 0;

                Console.Clear();
                Console.WriteLine("\n    Cadastro  de veiculos");
                Console.WriteLine("<<<---Lojas PossanteCar--->>> ");
                Console.WriteLine("\nMenu");
                Console.WriteLine("1-) Informar todos os dados\n" +
                                  "2-) Imprimir os dados que possui\n" +
                                  "3-) Finalizar o programa");

                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:

                        Console.WriteLine("Digite o Renavam");
                        int renavan = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o chassi");
                        string chassi = Console.ReadLine();
                        Console.WriteLine("Digite a placa");
                        string placa = Console.ReadLine();
                        Console.WriteLine("Digite a cor");
                        string cor = Console.ReadLine();
                        Console.WriteLine("Digite o modelo");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Digite o marca");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Digite o ano");
                        string ano = Console.ReadLine();
                        Console.WriteLine("Digite o nome do proprietario");
                        string nomeProprietario = Console.ReadLine();
                        Console.WriteLine("Digite o cpf");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento");
                        string dataNascimento = Console.ReadLine();
                        Console.WriteLine("Digite a data de compra");
                        string dataCompra = Console.ReadLine();
                        Console.WriteLine("\n<==Enderço do Proprietario==>");
                        Console.WriteLine("Digite o logradouro");
                        string logradouro = Console.ReadLine();
                        Console.WriteLine("Digite o numero");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a cidade");
                        string cidade = Console.ReadLine();
                        Console.WriteLine("Digite a CEP");
                        string cep = Console.ReadLine();
                        Console.WriteLine("Digite o Estado");
                        string estado = Console.ReadLine();

                        v.Renavan =renavan;
                        v.Chassi = chassi;
                        v.Placa = placa;
                        v.Cor = cor;
                        v.Modelo = modelo;
                        v.Marca = marca;
                        v.Ano = ano;
                        v.proprietario.Nome = nomeProprietario;
                        v.proprietario.Cpf = cpf;
                        v.proprietario.DataNascimento = dataNascimento;
                        v.proprietario.DataCompra = dataCompra;
                        v.proprietario.endereco.Logradouro = logradouro;
                        v.proprietario.endereco.Numero = numero;
                        v.proprietario.endereco.Cidade = cidade;
                        v.proprietario.endereco.Cep = cep;
                        v.proprietario.endereco.Estado = estado;

                        break;

                    case 2:

                        Console.WriteLine(v+"\n"+v.proprietario+"\n"+v.proprietario.endereco);
                        Console.ReadKey();
                        break;

                    case 3:
                        exit = false;
                        break;
                }
            }
            while (exit);
        }
    }
}
