namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Adicionar um construtor para a classe Iphone que chame o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // TODO: Inicializar outras propriedades específicas da classe Iphone, se houver
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Implementar a lógica para instalar o aplicativo em um dispositivo Iphone
            Console.WriteLine($"Instalando {nomeApp} no dispositivo Iphone...");
        }
    }
}