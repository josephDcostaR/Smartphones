using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;


public class Samsung : Smartphone
{
    public Samsung(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void DescricaoDoModelo()
    {
        Console.WriteLine($"Smartphone marca Samsung, numero: {Numero}, modelo: {ObterModelo()}, imei: {ObterIMEI()}, memoria: {ObterMemoria()}g.");
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp}... ");
    }
}
