Random rnd = new Random();
int n = rnd.Next(1,3);
Console.WriteLine("PEDRA PAPEL TESOURA!");
string machEsc = n == 1 ? "pedra" : n == 2 ? "papel" : "tesoura";
string userEsc;
bool win = false;
int winNum = 0;
    while(win == false){
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
        }else{
            Console.WriteLine("Você perdeu! Jogue novamente.");
        }
    }
    Console.WriteLine($"{winNum} tentativas para conseguir ganhar o jogo!");


