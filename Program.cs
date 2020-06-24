using System;
using System.Collections.Generic;

namespace Aula_23___Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cartao> cartoes = new List<Cartao>();

            Console.ForegroundColor = ConsoleColor.Green;
            cartoes.Add(new Cartao("Matheus", "4532 0285 7608 6318", "Visa", "24/05/2022", 474 ));
            cartoes.Add(new Cartao("Mirela", "5163 8888 0116 7495", "MasterCard", "24/09/2021", 978 ));
            cartoes.Add(new Cartao("Luisa", "6062 8280 0787 3173", "HiperCard", "24/03/2021", 421 ));

            cartoes.Add(new Cartao("João", "3728 3218 3199 583", "American Express", "03/22", 5134 ));
            cartoes.Add(new Cartao("Erick", "4576 8097 3272 6740", "Elo", "12/08/2026", 269 ));
            cartoes.Add(new Cartao("Milena", "3020 6073 5745 16", "Diners", "30/11/2021", 379 ));

            foreach (Cartao c in cartoes){
                System.Console.WriteLine($"\nTitular do Cartão: {c.Titular}.\nNumero: {c.Numero}.\nBandeira: {c.Bandeira}.\nVencimento: {c.Vencimento}.\nCódigo de Segurança (CVV): {c.CVV}.");
            }
        }
    }
}
