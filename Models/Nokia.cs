namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void DescricaoDoModelo()
        {
            Console.WriteLine($"Smartphone marca Nokia, numero: {Numero}, modelo: {ObterModelo()}, imei: {ObterIMEI()}, memoria: {ObterMemoria()}g.");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}... ");
        }
    }
}