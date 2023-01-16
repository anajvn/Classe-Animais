using System.ComponentModel.Design;

namespace Classe_Animais
{
    // Classes base (abstratas)
    public abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }
        public string Som { get; set; }

        public int Idade()
        {
            return DateTime.Now.Year - DataDeNascimento.Year;
        }
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

    // Interfaces Ações
    interface IOviparo
    {
        public void Botar();

        public void Chocar();
    }
    interface IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public void Voar();
    }
    interface IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }

        public void Mergulho();
    }

    public class Leao : Mamifero
    {
        public Leao(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
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
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Sim" +
                   $"\nPeçonhento = Não" +
                   $"\nQuantidade de mamas = {QuantidadeMamas}" +
                   $"\nCor do Pelo = {CorDoPelo}\n";
        }
    }
    public class Chacal : Mamifero
    {
        public Chacal(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
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
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Sim" +
                   $"\nPeçonhento = Não" +
                   $"\nQuantidade de mamas = {QuantidadeMamas}" +
                   $"\nCor do pelo = {CorDoPelo}\n";
        }
    }
    public class Morcego : Mamifero, IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Morcego(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
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
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Não" +
                   $"\nPeçonhento = Não" +
                   $"\nQuantidade de Mamas = {QuantidadeMamas}" +
                   $"\nCor do Pelo = {CorDoPelo}" +
                   $"\nAltitude máxima (m) = {AltitudeMaximaEmMetros}" +
                   $"\nVelocidade de voo = {VelocidadeDoVoo}\n";
        }

        public void Voar()
        {
            Console.WriteLine("*voando*");
        }
    }
    public class Cisne : Ave, IOviparo, IVoar, IAquatico
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }
        public Cisne(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
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
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Não" +
                   $"\nPeçonhento = Não" +
                   $"\nRapina = Não" +
                   $"\nCor da Pena = {CorPena}" +
                   $"\nAltitude Máxima(m) = {AltitudeMaximaEmMetros}" +
                   $"\nVelocidade do Voo = {VelocidadeDoVoo}" +
                   $"\nVive em terra = Sim" +
                   $"\nÁgua doce = Sim\n";
        }
        public void Voar()
        {
            Console.WriteLine("*voando*");
        }
        public void Botar()
        {
            Console.WriteLine("*botando ovo*");
        }
        public void Chocar()
        {
            Console.WriteLine("*sentado no ovo - chocando o filhote*");
        }
        public void Mergulho()
        {
            Console.WriteLine("*embaixo da água*");
        }
    }
    public class Arara : Ave, IOviparo, IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public Arara(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
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
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Não" +
                   $"\nPeçonhento = Não" +
                   $"\nRapina = Não" +
                   $"\nCor da Pena = {CorPena}" +
                   $"\nAltitude Máxima(m) = {AltitudeMaximaEmMetros}" +
                   $"\nVelocidade do Voo = {VelocidadeDoVoo}\n";
        }
        public void Voar()
        {
            Console.WriteLine("*voando*");
        }
        public void Botar()
        {
            Console.WriteLine("*botando ovo*");
        }
        public void Chocar()
        {
            Console.WriteLine("*sentado no ovo - chocando o filhote*");
        }
    }
    public class DragaoDeComodo : Reptil, IOviparo
    {
        public DragaoDeComodo(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
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
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Sim" +
                   $"\nPeçonhento = Não" +
                   $"\nTem escamas = Sim\n";
        }
        public void Botar()
        {
            Console.WriteLine("*botando ovo*");
        }
        public void Chocar()
        {
            Console.WriteLine("*sentado no ovo - chocando o filhote*");
        }
    }
    public class Lontra : Mamifero, IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }
        public Lontra(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            Som = "iriri";
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

            return $"Dados da Lontra: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Sim" +
                   $"\nPeçonhento = Não" +
                   $"\nTem escamas = Sim" +
                   $"\nQuantidade de mamas = {QuantidadeMamas}" +
                   $"\nTem pelos = Sim" +
                   $"\nCor do Pelo = {CorDoPelo}" +
                   $"\nVive em terra = Sim" +
                   $"\nÁgua doce = Sim\n";
        }
        public void Mergulho()
        {
            Console.WriteLine("*embaixo da água*");
        }
    }
    public class Pinguim : Ave, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }
        public Pinguim(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            Som = "grrrá";
            Rapina = false;
            CorPena = "Preto e Branco";
            ViveEmTerra = true;
            AguaDoce = false;
        }

        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do pinguim: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Sim" +
                   $"\nPeçonhento = Não" +
                   $"\nRapina = Não" +
                   $"\nCor da Pena = {CorPena}" +
                   $"\nVive em terra = Sim" +
                   $"\nÁgua doce = Não\n";
        }
        public void Botar()
        {
            Console.WriteLine("*botando ovo*");
        }
        public void Chocar()
        {
            Console.WriteLine("*sentado no ovo - chocando o filhote*");
        }
        public void Mergulho()
        {
            Console.WriteLine("*embaixo da água*");
        }
    }
    public class Coruja : Ave, IOviparo, IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public Coruja(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            Som = "uuh uuh";
            Rapina = true;
            CorPena = "Marrom-claro";
            AltitudeMaximaEmMetros = 11300;
            VelocidadeDoVoo = 100;
        }
        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados da coruja: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Sim" +
                   $"\nPeçonhento = Não" +
                   $"\nRapina = Sim" +
                   $"\nCor da Pena = {CorPena}" +
                   $"\nAltitude Máxima(m) = {AltitudeMaximaEmMetros}" +
                   $"\nVelocidade do Voo = {VelocidadeDoVoo}\n";
        }
        public void Voar()
        {
            Console.WriteLine("*voando*");
        }
        public void Botar()
        {
            Console.WriteLine("*botando ovo*");
        }
        public void Chocar()
        {
            Console.WriteLine("*sentado no ovo - chocando o filhote*");
        }
    }
    public class Elefante : Mamifero
    {
        public Elefante(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = false;
            Peconhento = false;
            Som = "fuumm uuuuh";
            QuantidadeMamas = 2;
            Pelos = true;
            CorDoPelo = "Cinza";
        }

        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do elefante: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Não" +
                   $"\nPeçonhento = Não" +
                   $"\nQuantidade de mamas = {QuantidadeMamas}" +
                   $"\nCor do Pelo = {CorDoPelo}\n";
        }
    }
    public class Jacare : Reptil, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }
        public Jacare(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            Som = "roar";
            TemEscamas = true;
            TemCasco = false;
            ViveEmTerra = true;
            AguaDoce = true;
        }
        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do Jacare: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Sim" +
                   $"\nPeçonhento = Não" +
                   $"\nTem escamas = Sim" +
                   $"\nVive em terra = Sim" +
                   $"\nÁgua doce = Sim\n";
        }
        public void Botar()
        {
            Console.WriteLine("*botando ovo*");
        }
        public void Chocar()
        {
            Console.WriteLine("*sentado no ovo - chocando o filhote*");
        }
        public void Mergulho()
        {
            Console.WriteLine("*embaixo da água*");
        }
    }
    public class Ornitorrinco : Mamifero, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool AguaDoce { get; set; }
        public Ornitorrinco(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            Som = "grrrr";
            QuantidadeMamas = 0;
            Pelos = true;
            CorDoPelo = "Marrom";
            ViveEmTerra = true;
            AguaDoce = true;
        }

        public string ToString()
        {
            string sexo = "masculino";
            if (Sexo == 'f' || Sexo == 'F')
                sexo = "feminino";

            return $"Dados do ornitorrinco: " +
                   $"\nNome: {Nome}" +
                   $"\nData de nascimento: {DataDeNascimento}" +
                   $"\nSexo = {sexo}" +
                   $"\nIdade = {Idade()}" +
                   $"\nCarnivoro = Sim" +
                   $"\nPeçonhento = Não" +
                   $"\nQuantidade de mamas = {QuantidadeMamas}" +
                   $"\nCor do Pelo = {CorDoPelo}" +
                   $"\nVive em terra = Sim" +
                   $"\nÁgua doce = Sim\n";
        }
        public void Botar()
        {
            Console.WriteLine("*botando ovo*");
        }
        public void Chocar()
        {
            Console.WriteLine("*sentado no ovo - chocando o filhote*");
        }
        public void Mergulho()
        {
            Console.WriteLine("*embaixo da água*");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Leao leao = new Leao("Simba", DateTime.Now, 'm');
            Console.WriteLine(leao.ToString());
            leao.Amamentar();
            leao.Movimentar();
            leao.Comunicar();
            leao.Alimentar();

            Chacal chacal = new Chacal("Chaks", DateTime.Now, 'f');
            Console.WriteLine("\n\n" + chacal.ToString());
            chacal.Amamentar();
            chacal.Movimentar();
            chacal.Comunicar();
            chacal.Alimentar();

            Morcego morcego = new Morcego("Morci", DateTime.Now, 'm');
            Console.WriteLine("\n\n" + morcego.ToString());
            morcego.Amamentar();
            morcego.Movimentar();
            morcego.Comunicar();
            morcego.Alimentar();
            morcego.Voar();

            Cisne cisne = new Cisne("Patinho feio", DateTime.Now, 'm');
            Console.WriteLine("\n\n" + cisne.ToString());
            cisne.Movimentar();
            cisne.Comunicar();
            cisne.Alimentar();
            cisne.Voar();
            cisne.Ciscar();
            cisne.Botar();
            cisne.Chocar();
            cisne.Mergulho();

            Arara arara = new Arara("Blu", DateTime.Now, 'm');
            Console.WriteLine("\n\n" + arara.ToString());
            arara.Movimentar();
            arara.Comunicar();
            arara.Alimentar();
            arara.Voar();
            arara.Ciscar();
            arara.Botar();
            arara.Chocar();

            DragaoDeComodo dragao = new DragaoDeComodo("Drags", DateTime.Now, 'f');
            Console.WriteLine("\n\n" + dragao.ToString());
            dragao.Movimentar();
            dragao.Comunicar();
            dragao.Alimentar();
            dragao.Botar();
            dragao.Chocar();

            Lontra lontra = new Lontra("Lon", DateTime.Now, 'm');
            Console.WriteLine("\n\n" + lontra.ToString());
            lontra.Movimentar();
            lontra.Comunicar();
            lontra.Alimentar();
            lontra.Amamentar();
            lontra.Mergulho();

            Pinguim pinguim = new Pinguim("Club", DateTime.Now, 'n');
            Console.WriteLine("\n\n" + pinguim.ToString());
            pinguim.Movimentar();
            pinguim.Comunicar();
            pinguim.Alimentar();
            pinguim.Botar();
            pinguim.Chocar();
            pinguim.Ciscar();
            pinguim.Mergulho();

            Coruja coruja = new Coruja("Edwiges", DateTime.Now, 'm');
            Console.WriteLine("\n\n" + coruja.ToString());
            coruja.Movimentar();
            coruja.Comunicar();
            coruja.Alimentar();
            coruja.Voar();
            coruja.Ciscar();
            coruja.Botar();
            coruja.Chocar();

            Elefante elefante = new Elefante("Dumbo", DateTime.Now, 'm');
            Console.WriteLine("\n\n" + elefante.ToString());
            elefante.Amamentar();
            elefante.Movimentar();
            elefante.Comunicar();
            elefante.Alimentar();

            Jacare jacare = new Jacare("Jaca", DateTime.Now, 'f');
            Console.WriteLine("\n\n" + jacare.ToString());
            jacare.Movimentar();
            jacare.Comunicar();
            jacare.Alimentar();
            jacare.Botar();
            jacare.Chocar();
            jacare.Mergulho();

            Ornitorrinco ornito = new Ornitorrinco("Perry", DateTime.Now, 'm');
            Console.WriteLine("\n\n" + ornito.ToString());
            ornito.Amamentar();
            ornito.Movimentar();
            ornito.Comunicar();
            ornito.Alimentar();
            ornito.Botar();
            ornito.Chocar();
            ornito.Mergulho();

        }
    }
}