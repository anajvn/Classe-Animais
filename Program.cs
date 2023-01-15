using System.ComponentModel.Design;

namespace Classe_Animais
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }
        public string Som { get; set; }

        public void Movimentar()
        {
            Console.WriteLine("*caminhando*");
        }

        public void Comunicar()
        {
            Console.WriteLine($"*{Som}*");
        }

        public void Alimentar()
        {
            string alimento = "plantas";
            if (Carnivoro)
                alimento = "carne";

            Console.WriteLine($"*comendo {alimento}*");
        }
    }

    public abstract class Mamifero : Animal
    {
        public int QuantidadeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoPelo { get; set; }

        public void Amamentar()
        {
            Console.WriteLine("*amamentando o filhote*");
        }
    }

    public abstract class Ave : Animal
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }

        public void Ciscar()
        {
            Console.WriteLine("*ciscando*");
        }
    }

    public abstract class Reptil : Animal
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }
    }

    interface IOviparo
    {
        public void Botar()
        {
            Console.WriteLine("*botando ovo*");
        }

        public void Chocar()
        {
            Console.WriteLine("*sentado no ovo - chocando o filhote*");
        }
    }

    interface IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Voar()
        {
            Console.WriteLine("*voando*");
        }
    }

    interface IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }

        public void Mergulho()
        {
            Console.WriteLine("*embaixo da água*");
        }
    }

    public class Leao : Mamifero
    {
        public Leao(string nome, DateTime dataDeNascimento, char sexo, int idade)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = true;
            Peconhento = false;
            Som = "ROAR";
            QuantidadeMamas = 6;
            Pelos = true;
            CorDoPelo = "Caramelo";
        }

        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do leão: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade}" +
                   $"Carnivoro = Sim" +
                   $"Peçonhento = Não" +
                   $"Quantidade de mamas = {QuantidadeMamas}" +
                   $"Cor do Pelo = {CorDoPelo}";
        }
    }
    public class Chacal : Mamifero
    {
        public Chacal(string nome, DateTime dataDeNascimento, char sexo, int idade)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = true;
            Peconhento = false;
            Som = "rrrrr";
            QuantidadeMamas = 6;
            Pelos = true;
            CorDoPelo = "Caramelo com manchas pretas";
        }

        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do chacal: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade}" +
                   $"Carnivoro = Sim" +
                   $"Peçonhento = Não" +
                   $"Quantidade de mamas = {QuantidadeMamas}" +
                   $"Cor do pelo = {CorDoPelo}";
        }
    }
    public class Morcego : Mamifero, IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Morcego(string nome, DateTime dataDeNascimento, char sexo, int idade)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = false;
            Peconhento = false;
            Som = "ti ti ti ti";
            QuantidadeMamas = 2;
            Pelos = true;
            CorDoPelo = "Cinza escuro";
            AltitudeMaximaEmMetros = 1100;
            VelocidadeDoVoo = 160;
        }

        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do morcego: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade}" +
                   $"Carnivoro = Não" +
                   $"Peçonhento = Não" +
                   $"Quantidade de Mamas = {QuantidadeMamas}" +
                   $"Cor do Pelo = {CorDoPelo}" +
                   $"Altitude máxima (m) = {AltitudeMaximaEmMetros}" +
                   $"Velocidade de voo = {VelocidadeDoVoo}";
        }
    }
    public class Cisne : Ave, IOviparo, IVoar, IAquatico
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }
        public Cisne(string nome, DateTime dataDeNascimento, char sexo, int idade)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = false;
            Peconhento = false;
            Som = "ahn ahn ahn";
            Rapina = false;
            CorPena = "Branco";
            AltitudeMaximaEmMetros = 8200;
            VelocidadeDoVoo = 100;
            ViveEmTerra = true;
            AguaDoce = true;
        }

        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do cisne: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade}" +
                   $"Carnivoro = Não" +
                   $"Peçonhento = Não" +
                   $"Rapina = Não" +
                   $"Cor da Pena = {CorPena}" +
                   $"Altitude Máxima(m) = {AltitudeMaximaEmMetros}" +
                   $"Velocidade do Voo = {VelocidadeDoVoo}" +
                   $"Vive em terra = Sim" +
                   $"Água doce = Sim";
        }

    }
    public class Arara : Ave, IOviparo, IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public Arara(string nome, DateTime dataDeNascimento, char sexo, int idade)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = false;
            Peconhento = false;
            Som = "reco-reco";
            Rapina = false;
            CorPena = "Amarelo, azul, vermelho e verde";
            AltitudeMaximaEmMetros = 1650;
            VelocidadeDoVoo = 143;
        }
        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados da arara: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade}" +
                   $"Carnivoro = Não" +
                   $"Peçonhento = Não" +
                   $"Rapina = Não" +
                   $"Cor da Pena = {CorPena}" +
                   $"Altitude Máxima(m) = {AltitudeMaximaEmMetros}" +
                   $"Velocidade do Voo = {VelocidadeDoVoo}";
        }
    }
    public class DragaoDeComodo : Reptil, IOviparo
    {
        public DragaoDeComodo(string nome, DateTime dataDeNascimento, char sexo, int idade)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = true;
            Peconhento = false;
            Som = "roar";
            TemEscamas = true;
            TemCasco = false;
        }
        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do Dragao De Comodo: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade}" +
                   $"Carnivoro = Sim" +
                   $"Peçonhento = Não" +
                   $"Tem escamas = Sim";
        }
    }
    public class Lontra : Mamifero, IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }
        public Lontra(string nome, DateTime dataDeNascimento, char sexo, int idade)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = true;
            Peconhento = false;
            Som = "roar";
            QuantidadeMamas = 2;
            Pelos = true;
            CorDoPelo = "Marrom-escuro";
            ViveEmTerra = true;
            AguaDoce = true;
        }
        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do Lontra: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade}" +
                   $"Carnivoro = Sim" +
                   $"Peçonhento = Não" +
                   $"Tem escamas = Sim" +
                   $"Quantidade de mamas = {QuantidadeMamas}" +
                   $"Tem pelos = Sim" +
                   $"Cor do Pelo = {CorDoPelo}" +
                   $"Vive em terra = Sim" +
                   $"Água doce = Sim";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}