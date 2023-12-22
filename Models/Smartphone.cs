using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementa as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Passa os parâmetros do construtor para as propriedades
            Numero = ValidarNumero(numero);
            Modelo = modelo;
            IMEI = ValidarIMEI(imei);
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void InstalarAplicativo(string nomeApp)
         {
            Console.WriteLine($"App {nomeApp} instalado com sucesso");
        }

  private string ValidarNumero(string numero)
        {
            string pattern = @"^[0-9]+$";
            if (!Regex.IsMatch(numero, pattern))
            {
                throw new ArgumentException("Numero must only contain numbers");
            }
            return numero;
        }

        private string ValidarIMEI(string imei)
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