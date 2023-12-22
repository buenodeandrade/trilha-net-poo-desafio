using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementa as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Passa os parâmetros do construtor para as propriedades
            Numero = ValidarNumero(numero);
            Modelo = modelo;
            IMEI = ValidarIMEI(imei);
            Memoria = memoria;
        }

        public static void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public static void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void InstalarAplicativo(string nomeApp)
         {
            Console.WriteLine($"App {nomeApp} instalado com sucesso");
        }

        private static string ValidarNumero(string numero)
        {
            string pattern = @"^[0-9]+$";
            if (!Regex.IsMatch(numero, pattern))
            {
                throw new ArgumentException("Numero must only contain numbers");
            }
            return numero;
        }

        private static string ValidarIMEI(string imei)
        {
            string pattern = @"^[0-9]{15,17}$";
            if (!Regex.IsMatch(imei, pattern))
            {
                throw new ArgumentException("IMEI deve ter de 15 a 17 caracteres e conter apenas números.");
            }
            return imei;
        }
    }
}