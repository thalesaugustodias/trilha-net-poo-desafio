namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} 99%... Aguarde!");
            Console.WriteLine("100% completo");
            System.Console.WriteLine($"O {nomeApp} foi instalado com sucesso!");
        }
    }
}