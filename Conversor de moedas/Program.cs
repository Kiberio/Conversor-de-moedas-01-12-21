//Daniel Hiroshi Fugikawa - 200209
//https://economia.uol.com.br/noticias/redacao/2021/11/24/dolar-comercial-opera-em-queda-r-5606.htm
//https://g1.globo.com/economia/noticia/2021/09/20/alta-do-iof-entra-em-vigor-e-encarece-o-credito-a-partir-desta-segunda-veja-como-ele-pode-afetar-o-seu-bolso.ghtml

using System;



namespace Conversor_de_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando informações para o usuario
            Console.WriteLine("Qual é a cotação do dólar ? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você ira comprar? ");
            double CDolar = double.Parse(Console.ReadLine());
            
            //Calculo do Valor a ser pago e imprimir para o usuario
            double Vpago = cotacao * CDolar;
            Console.WriteLine( $"Valor a ser pago em reais = ${Vpago} ");
            
            //Calculo Para Valor total com IOF
            double IOF = 4.08;
            double IOFC = Vpago*4.08 / 100;
            double Valortot = Vpago + IOFC;

            //Imprimir os valores do IOF e adicionar no valor de compra das moedas
            Console.WriteLine($"Valor a ser pago de IOF = {IOF}% ");
            Console.WriteLine("ATENÇÃO: VALOR DE IOF PARA PESSOA FISICA DO DIA 20/09/2021");
            Console.WriteLine($"Valor total da compra com IOF = ${Valortot} ");
            Console.ReadKey();
        }
    }
}
