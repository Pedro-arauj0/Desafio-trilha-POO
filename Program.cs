using DesafioTrilha_POO.Models;

class Program
{
    static void Main()
    {
        // Criando instâncias de Nokia e iPhone
        var nokia = new Nokia("123456", "Nokia 3310", "11111111111", 16);
        var iphone = new Iphone("987654", "iPhone 15", "99999999999", 128);

        // Testando métodos
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");
        nokia.ReceberLigacao();

        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
        iphone.ReceberLigacao();
    }
}
