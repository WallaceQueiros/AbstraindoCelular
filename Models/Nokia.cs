namespace DesafioPOO.Models
{
    // Classe Nokia herda da classe abstrata Smartphone
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia que repassa os parâmetros para a classe base (‘Smartphone’)
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        
        // Implementação obrigatória do método abstrato da classe base
        // Define qual o aplicativo será "instalado" no ‘smartphone’ Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando Aplicativo {nomeApp} no Smartphone Nokia");
        }
    }
}