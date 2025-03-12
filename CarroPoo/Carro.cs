/* Ex2. e Ex3. 
Classe Carro.cs */

class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Velocidade { get; set; }
    private int ano;
    public int Ano
    {
        get => ano;
        set
        {
            if (value >= 1960 && value <= 2023)
            {
                ano = value;
            }
            else
            {
                Console.WriteLine("Valor inválido. Insira um ano entre 1960 e 2023!");
            }
        }
    }
    public string DescricaoDetalhada => $"Carro: {this.Marca} {this.Modelo} {this.Ano}";

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
        Velocidade = Velocidade + 1;
    }

    public void Frear()
    {
        Console.WriteLine("Freando...");
        Velocidade = Velocidade - 1;
    }

    public void Buzinar()
    {
        Console.WriteLine("fon fon");
    }
}