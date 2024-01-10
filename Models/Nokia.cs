namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Adicionar um construtor para a classe Nokia que chame o construtor da classe base
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // TODO: Inicializar outras propriedades específicas da classe Nokia, se houver
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Implementar a lógica para instalar o aplicativo em um dispositivo Nokia
            Console.WriteLine($"Instalando {nomeApp} no dispositivo Nokia...");
        }
    }
}