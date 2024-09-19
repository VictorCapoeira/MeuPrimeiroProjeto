# MeuPrimeiroProjeto
**Jogo de PEDRA-PAPEL-TESOURA**

![image](https://github.com/user-attachments/assets/aaa1bc62-ffd2-4516-aad2-9e4705c28dac)

![image](https://github.com/user-attachments/assets/d0608f58-f66a-45a4-80f3-0b85495f17a6)

![image](https://github.com/user-attachments/assets/76c32f62-de45-4258-8fb8-8bbdce811feb)



O projeto é um simples jogo de pedra, papel e tesoura, aonde o objetivo é o jogador derrotar a máquina. O jogador deve inserir "pedra, papel ou tesoura" até derrotar a máquina! Ao fim, a quantidade de tentativas será exibida. BOA SORTE!

## Quer fazer um jogo igual? Aprenda a lógica por trás dele!
Basicamente, a lógica por de trás do jogo é muito simples! É apenas uma comparação entre o valor que o user inseriu e o valor que a máquina recebeu. A parte mais "complexa"(se assim pode ser dita) é construir a comparaçã desses valores. Para coletar o valor que o user inseriu, apenas usar uma variavel "string"é o suficiente. No entanto, é recomendado converter essa string com "ToLower()" que é uma funçã que torna um texto em minisculo, desse modo, ficará mais facil comparar valores no futuro. Afinal, como tudo será minisculo, não será necessario se preocupar que alguma parte do texto esteja maisculo. Para coletar os dados da máquina um processo mais "complexo" é necessário. Primeiro é importante pensar em um modo de fazer isso! No caso desse projeto, primeiro um objeto "Random" foi instanciado em "rnd". Com esse objeto é possivel usar um metodo que gera numeros aleatorios. Após, uma outra variavel foi criada "n" com o intuito de usar o metodo Next(passando dois valores, assim possivel criar um intervalo de valores que podem ser sorteados). Após a variavel "n" guardar esse valor, uma outra variavel "string" foi criada "machEsc" e ela foi preenchida usando um operator ternario. Caso o numero sorteado seja "1", essa variavel será criada com o valor "pedra", caso seja "2" a variavel será criada com o valor "papel", caso seja outra valor, ela será criado com o valor "tesoura". Otimo, já temos os meios para coletar os dois valores! Agora basta comparar esses valores. Uma estrutura de repetição foi criada, para que assim o usuario seja capaz de jogar quantas vezes forem necessarias.  Uma variavel "bool"(iniciada como false) foi criado para servir de condição de reptição, enquant a variavel for "false" o loop vai se repetir, e essa variavel só vai ficar "true" quando o user ganhar o jogo! Uma variavel "int" foi criada para contar as tentativas do jogador! Todas vez que o jogador inserir um dado, uma tentativa será contabilizada, assim, ao fim, será póssivel saber a quantidade de vezes que ele jogou! Após coletar os dois valores, basta fazer algumas compações. Se o jogo dá maquina for pedra e o do jogador foi papel, o jogador ganha o jogo. Se o jogo dá maquina for tesoura e o do jogador foi pedra, o jogador ganha o jogo. Se o jogo dá maquina for papel e o do jogador foi tesoura, o jogador ganha o jogo. Caso não seja nenhum desses cenarios, que dizer que o jogador perdeu e deve tentar novamente!


