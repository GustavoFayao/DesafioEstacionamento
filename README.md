# DesafioEstacionamentoClaro! Aqui está uma descrição detalhada do que você fez, formatada para ser incluída no seu repositório GitHub, com ícones e tudo:

---

## 🚗 Sistema de Estacionamento

Este projeto implementa um sistema de estacionamento em C#, permitindo adicionar, remover e listar veículos estacionados. Abaixo está uma descrição das funcionalidades implementadas:

### 📂 Estrutura do Projeto

O projeto está organizado da seguinte forma:

```
DesafioFundamentos
├── Models
│   └── Estacionamento.cs
```

### 📋 Funcionalidades

#### 1. Adicionar Veículo

O método `AdicionarVeiculo` solicita ao usuário que digite a placa do veículo e a adiciona à lista de veículos estacionados.

```csharp
public void AdicionarVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para estacionar:");
    string placa = Console.ReadLine();
    veiculos.Add(placa);
    Console.WriteLine("Veículo estacionado com sucesso!");
}
```

#### 2. Remover Veículo

O método `RemoverVeiculo` solicita ao usuário que digite a placa do veículo a ser removido e calcula o valor total a ser pago com base no tempo de permanência.

```csharp
public void RemoverVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para remover:");
    string placa = Console.ReadLine();

    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        int horas = int.Parse(Console.ReadLine());
        decimal valorTotal = precoInicial + precoPorHora * horas;
        veiculos.Remove(placa);
        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
    }
    else
    {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
    }
}
```

#### 3. Listar Veículos

O método `ListarVeiculos` exibe todos os veículos atualmente estacionados.

```csharp
public void ListarVeiculos()
{
    if (veiculos.Any())
    {
        Console.WriteLine("Os veículos estacionados são:");
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine(veiculo);
        }
    }
    else
    {
        Console.WriteLine("Não há veículos estacionados.");
    }
}
```

### 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET**

### 📜 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
