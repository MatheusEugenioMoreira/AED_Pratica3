using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAbstratosDeDados
{
    class TestaLista
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int c, op;

            do
            {
                Console.Write("Digite a opção desejada:\n1- inserir\n2- pesquisar\n3- imprimir lista\n4 sair\n-----------------------\n");
                op = int.Parse(Console.ReadLine());
                //1 Inserir
                if (op == 1)
                {
                    Console.Write("Digite um nº (-1 para sair): ");
                    c = int.Parse(Console.ReadLine());

                    while (c != -1)
                    {
                        NoLista n = l.pesquisar(c);
                        if (n == null)
                        {
                            Console.Write("Digite um nome (-1 para sair): ");
                            string nome = Console.ReadLine();
                            l.inserir(new NoLista(c, nome));
                        }
                        else
                        {
                            Console.WriteLine("ERRO: CHAVE DUPLICADA");
                        }
                        Console.Write("Digite outro nº (-1 para sair): ");
                        c = int.Parse(Console.ReadLine());

                    }
                }

                //2 pesquisar
                else if (op == 2)
                {
                    Console.Write("Digite um nº a ser pesquisado: ");
                    c = int.Parse(Console.ReadLine());
                    NoLista n = l.pesquisar(c);

                    if (n == null)
                        Console.WriteLine("Valor não encontrado!");
                    else
                        Console.WriteLine("Achou: A chave: " + n.chave + ", Nome: " + n.nome + " (digite 5 para remover)");

                    if (op == 5)
                    {
                        l.remover(c);
                        Console.Write("Chave " + n.chave + " Nome: " + n.nome + " foi removido com sucesso.");
                    }
                }

                //3 imprimir lista
                if (op == 3)
                {
                    l.imprimir();
                }
            }
            while (op != 4);


        }
    }
}