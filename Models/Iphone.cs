namespace DesafioPOO.Models
{
    // Classe Iphone herda da classe abstrata Smartphone
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que repassa os parâmetros para a classe base (‘Smartphone’)
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // Implementação obrigatória do método abstrato da classe base
        // Define qual o aplicativo será "instalado" no ‘smartphone’ Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando Aplicativo {nomeApp} no Smartphone Iphone");
        }
    }
}