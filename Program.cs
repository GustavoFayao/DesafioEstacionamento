﻿using  DesafioEstacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento\n" + "Digite o  preço inicial");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento es = new Estacionamento(precoInicial,precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu){
    
    Console.Clear();
    Console.WriteLine("Digite sua opção");
    Console.WriteLine("1 - Cadastra Veiculo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Lista Veículos");
    Console.WriteLine("4 - encerrar");


    switch(Console.ReadLine()){

        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadLine();

}

Console.WriteLine("O programa se encerrou");