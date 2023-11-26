# Calculadora Simples em C#

## Descrição do Projeto

Este é um projeto de uma calculadora simples em C# que permite realizar operações básicas, como soma, subtração, multiplicação, divisão, cálculo de porcentagem e resolução da fórmula de Bhaskara para equações do segundo grau.

Esse projeto foi realizado a partir do curso de Fundamentos de C# do [Balta.io](https://balta.io/).

## Funcionalidades

1. **Soma:** Adiciona dois números inseridos pelo usuário.
2. **Subtração:** Subtrai o segundo número do primeiro, ambos fornecidos pelo usuário.
3. **Multiplicação:** Multiplica dois números inseridos pelo usuário.
4. **Divisão:** Divide o primeiro número pelo segundo, ambos fornecidos pelo usuário.
5. **Porcentagem:** Calcula a porcentagem de um valor em relação a outro.
6. **Fórmula de Bhaskara:** Resolve equações do segundo grau (ax² + bx + c) fornecendo as raízes reais, quando existem, e o valor do delta.

## Como Utilizar

### Pré-requisitos
- É necessário ter .NET instalado na máquina, você pode encontrar um instalador [aqui](https://dotnet.microsoft.com).

### Como executar?
1. Abra o terminal na pasta que o projeto foi salvo.
2. Execute o comando `dotnet run`

Ao executar o programa, o usuário é apresentado a um menu onde pode escolher a operação desejada. Após cada operação, o programa retorna ao menu principal e ao selecionar a opção de saída, o programa é encerrado.

## Observações
- Caso o usuário insira um valor inválido ao solicitar um número, o programa considerará o valor como 0 e exibirá um aviso.
- O cálculo da fórmula de Bhaskara verifica a existência de raízes reais com base no delta, fornecendo as raízes e o valor de delta.

## Como Contribuir
Se deseja contribuir para este projeto, sinta-se à vontade para abrir problemas (issues) ou enviar solicitações de pull (pull requests). Sua contribuição é bem-vinda!

## Autor
Este projeto foi desenvolvido por Emanuel Jose ([@emanueljsweb](https://github.com/emanueljsweb)).

## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](/LICENSE) para mais detalhes.