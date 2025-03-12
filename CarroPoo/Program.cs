/* Ex2. e Ex3. 
Classe Program.cs */

Carro carro1 = new Carro();

carro1.Marca = "VolksWagen";
carro1.Modelo = "Fusca";
carro1.Velocidade = 100;
carro1.Ano = 1980;


Console.WriteLine(carro1.DescricaoDetalhada);
carro1.Acelerar();
carro1.Frear();
carro1.Buzinar();