namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

         public override void DescricaoDoModelo()
        {
            Console.WriteLine($"Smartphone marca iphone, numero: {Numero}, modelo: {ObterModelo()}, imei: {ObterIMEI()}, memoria: {ObterMemoria()}g.");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}... ");
        }
    }
}