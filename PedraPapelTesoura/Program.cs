Random rnd = new Random();
Console.WriteLine("PEDRA PAPEL TESOURA!");
string userEsc;
bool win = false;
int winNum = 0;
    while(win == false){
        int n = rnd.Next(1,3);
        string machEsc = n == 1 ? "pedra" : n == 2 ? "papel" : "tesoura";
        Console.WriteLine("Escolha entre pedra, papel ou tesoura: ");
        userEsc = Console.ReadLine().ToLower();
        winNum++;
        if(machEsc == "pedra" && userEsc == "papel"){
            Console.WriteLine("Você venceu!!!");
            win = true;
        }else if(machEsc == "tesoura" && userEsc == "pedra"){
            Console.WriteLine("Você venceu!!!");
            win = true;
        }else if(machEsc == "papel" && userEsc == "tesoura"){
            Console.WriteLine("Você venceu!!!");
            win = true;
        }
        else if(machEsc == userEsc){
            Console.WriteLine("Você empatou com a máquina! Jogue novamente.");
        }else
            Console.WriteLine("Você perdeu! Jogue novamente.");
    }
    string mensagem = winNum == 1 ? $"{winNum} tentativa para conseguir ganhar o jogo! Parabéns, você é muito bom!!!" : winNum > 1 && winNum <= 8 ? $"{winNum} tentativas para conseguir ganhar o jogo!" : $"{winNum} tentativas para conseguir ganhar o jogo! Você levou uma surra, pede benção para a máquina KKKKKKKKK";
     
    Console.WriteLine(mensagem);
    
    