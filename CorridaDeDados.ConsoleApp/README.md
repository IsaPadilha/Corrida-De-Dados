# Corrida De Dados

## Introdução

A Corrida de Dados é um jogo simples que funciona em turnos, onde o usuário disputa contra o computador para alcançar a linha de chegada. O jogo conta com penalidades e bônus para acelerar ou retardar o progresso.

## Regras do Jogo

1. O jogo tem um limite de 30 casas;

2. O usuário e o computador jogam alternadamente;

3. Cada turno, o dado é responsável para sortar valores entre 1 e 6 para determinar o avanço;

4. Eventos especiais ocorrem em determinadas posições.

- Avanço extra (+3 casas): Posições: 5, 10, 15 e 25.

- Recuo (-2 casas): 7, 13 e 20.

5. O primeiro a cruzar a linha de chegada é o vencedor.

## Como utilizar

1. Clone o repositório ou baixe o código fonte;

2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz;

3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Para executar o projeto compilando em tempo real

```
donet run --project CorridaDeDados.ConsoleApp
```

## Requisitos
- .NET 10.0 SDK