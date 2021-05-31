using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Fiat2";
            Dono donoJoao = new Dono();
            donoJoao.Nome = "João";
            donoJoao.Idade = 30;
            Dono donoMaria = new Dono();
            donoMaria.Nome = "Maria";
            donoMaria.Idade = 28;
            carro.AdicionarAntigoDono(donoJoao);
            carro.AdicionarAntigoDono(donoMaria);
            foreach (Dono dono in carro.GetAntigosDonos())
            {
                Console.WriteLine("Um dos antigos donos é {0} com idade de {1}", dono.Nome, dono.Idade);
            }
            Console.WriteLine(carro.Ligar());
            Console.WriteLine("Este carro tem {0} portas", carro.NumeroPortas);
            Carro carro2 = new Carro("Astra");
            Console.WriteLine("Esse outro carro se chama {0}", carro2.Nome);
            Carro carro3 = new Carro("Ford", 2);
            Console.WriteLine("Esse outro carro é da marca {0} e tem {1} portas", carro3.Marca, carro3.NumeroPortas);
            Carro carro4 = new Carro(6);
            Console.WriteLine("Já esse outo carro tem {0} portas", carro4.NumeroPortas);
            Carro carro5 = new Carro(nome: "Ka", marca: "Ford", quantidadePortas: 2);
            Console.WriteLine("Agora, esse carro é da marca {0}, nome {1} e tem {2} portas", carro5.Marca, carro5.Nome, carro5.NumeroPortas);
            Carro carro6 = new Carro
            {
                Nome = "Astra",
                Marca = "GM",
                NumeroPortas = 4,
                Potencia = 1.4
            };
            Console.WriteLine("Agora, já este carro se chama {0}, é da marca {1}, possui {2} portas e tem potência de {3}",
                carro6.Nome,
                carro6.Marca,
                carro6.NumeroPortas,
                carro6.Potencia);
            Carro carro7 = new Carro();
            Console.WriteLine("Mensagem do carro 7: {0}", carro7.Ligar());
            Moto moto1 = new Moto();
            moto1.Nome = "Titan";
            moto1.Marca = "Honda";
            moto1.Potencia = 150;
            moto1.CapacidadeTanque = 15;
            Console.WriteLine("Essa moto se chama {0}, da marca {1}, com potência de {2} e capacidade do tanque de {3}",
                moto1.Nome,
                moto1.Marca,
                moto1.Potencia,
                moto1.CapacidadeTanque);

            Carro carroFord = new Carro();
            carroFord.Nome = "Ka";
            carroFord.Marca = "Ford";
            Carro carroFord2 = new Carro();
            carroFord2.Nome = "Ka";
            carroFord2.Marca = "Ford";
            Console.WriteLine(carroFord.Ligar());
            Console.WriteLine("GetHashCode = {0}", carroFord.GetHashCode());
            Console.WriteLine("ToString = {0}", carroFord.ToString());
            Console.WriteLine("Equals = {0}", carroFord.Equals(carroFord2));
            Veiculo meuCarro = new Carro();
            Veiculo minhaMoto = new Moto();
            Console.WriteLine("Ligando o carro: {0}", meuCarro.Ligar());
            Console.WriteLine("Ligando a moto: {0}", minhaMoto.Ligar());
            Console.WriteLine("Desligando o carro: {0}", meuCarro.Desligar());
            Console.WriteLine("Desligando a moto: {0}", minhaMoto.Desligar());
            Console.WriteLine("Abastecendo o carro: {0}", meuCarro.Abastecer());
            Console.WriteLine("Abastececndo a moto: {0}", minhaMoto.Abastecer());
            Console.WriteLine("Desabastecendo o carro: {0}", meuCarro.Desabastecer());
            Console.WriteLine("Desabastecendo a moto: {0}", minhaMoto.Desabastecer());
            Veiculo meuVeiculo = new Carro();
            Console.WriteLine("Mensagem do veículo: {0}", meuVeiculo.Ligar());
            IVeiculo meuCaminhao = new Caminhao();
            Console.WriteLine("Mensagem do caminhão: {0}", meuCaminhao.Ligar());
            Console.WriteLine("Abastecendo o caminhão: {0}", meuCaminhao.Abastecer());
            Console.WriteLine("Desabastecendo o caminhão: {0}", meuCaminhao.Desabastecer());
            Console.ReadKey();
        }
    }
}
