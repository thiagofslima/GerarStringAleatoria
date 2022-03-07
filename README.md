É utilizado Enumerable.Repeat que serve para gerenciar uma sequência que contém um valor repetido, que recebe dois parâmetros, o primeiro é o valor a ser repetido e o segundo é o numero de vezes que se repete.

Depois é utilizado o método Select do LINQ, iterando a cada linha e utilizando a expressão random.Nextque recebe como parâmetro um int32 que representa o numero máximo de retorno.

Dentro do select tem a expressão s => s[random.Next(s.Length)] , no caso s é uma linha com esse conteúdo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" random.Next(s.Length) vai gerar um numero aleatório pegando um carácter da string, onde s.Length é tamanho total de caracteres da string.

.ToArray() coloca todos os caracteres retornados em uma array de caracteres.

new string() transforma essa array de caracteres em uma string.
