namespace RecuPOO2023.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(1000);
            Peso peso = new Peso(20000);
            Peso peso2 = new Peso(1000);
            Euro euro = new Euro(1000);

            Billetera billetera = new Billetera();

            Console.WriteLine(billetera.ExtraerDinero(new Peso(100)));

            string info = billetera;
            Console.WriteLine(info);


            Console.WriteLine(billetera.IngresarDinero(dolar));
            Console.WriteLine(billetera.IngresarDinero(euro));
            Console.WriteLine(billetera.IngresarDinero(peso));
            Console.WriteLine(billetera.IngresarDinero(peso2));

            Dolar dolarRetirar = new Dolar(2000);
            Console.WriteLine(billetera.ExtraerDinero(dolarRetirar));

            Peso pesoRetirar = new Peso(1500);
            Console.WriteLine(billetera.ExtraerDinero(pesoRetirar));


            info = billetera;
            Console.WriteLine(info);

            Console.WriteLine(billetera[0].MostrarInfo());

            ManejadorArchivoXml manejadorArchivo = new ManejadorArchivoXml();
            manejadorArchivo.GuardarMonedas(billetera.GetMonedas());
        }
    }
}
