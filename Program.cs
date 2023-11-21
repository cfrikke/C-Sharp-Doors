public class Program
{
    public static void Main()
    {
        
        Random rnd = new Random();
        int DupeDoor = rnd.Next(1, 4);
        bool GotDuped = false;
        string input;
        int room = 0;
        int health = 100;
        int i;
        char[] YouDied = {'Y', 'O', 'U', ' ', 'D', 'I', 'E', 'D'};
        char[] YouWin = {'Y', 'O', 'U', ' ', 'W', 'I', 'N', '!', '!', '!'};
            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            Console.Clear();
            Console.WriteLine("  █████████                                                                                      ");
            Console.WriteLine("  ████████████                                                                                   ");
            Console.WriteLine("  ██████████████                                                                                 ");
            Console.WriteLine("  ███████████████                                                                                ");
            Console.WriteLine("  █████   ████████      ███████████        ███████████     ████   ████████       █████████       ");
            Console.WriteLine("  █████    ████████   ███████████████    ███████████████   ████████████████    █████████████     ");
            Console.WriteLine("  █████     ███████  █████████████████  █████████████████  █████████████████  ███████████████    ");
            Console.WriteLine("  █████     ███████  █████████████████  █████████████████  ████████   ██████  ███████    ████    ");
            Console.WriteLine("  █████     ███████  ██████     ██████  ██████     ██████  ███████     █████  ███████            ");
            Console.WriteLine("  █████     ███████  ██████     ██████  ██████     ██████  ███████     █████     ████████        ");
            Console.WriteLine("  █████    ████████  ██████     ██████  ██████     ██████  ███████                 ████████      ");
            Console.WriteLine("  █████   ████████   ██████     ██████  ██████     ██████  ███████                    ███████    ");
            Console.WriteLine("  ███████████████    █████████████████  █████████████████  ███████            ████    ███████    ");
            Console.WriteLine("  ██████████████     █████████████████  █████████████████  ███████            ███████████████    ");
            Console.WriteLine("  ████████████        ███████████████    ███████████████   ███████            ██████████████     ");
            Console.WriteLine("  █████████             ███████████        ███████████     ███████             ███████████       ");
            Console.WriteLine("                                                                                                 ");
            Console.WriteLine("                                    Press Enter To Continue                                      ");
            Console.ReadLine();
        
        
        while(room < 10){
            Console.Clear();
            if(!GotDuped){
            DupeDoor = rnd.Next(1, 4);
            
            do{
             d1 = rnd.Next(-1, 2);
            }while(d1 == 0);
            do{
             d2 = rnd.Next(-1, 2);
            }while(d2 == 0);
            do{
             d3 = rnd.Next(-1, 2);
            }while(d3 == 0);
            }








        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Room {room}");
        Console.WriteLine("Choose a door (1, 2, or 3):");
        Console.WriteLine(" ▐▀▀▀▀▀▀▌ ▐▀▀▀▀▀▀▌ ▐▀▀▀▀▀▀▌ ");
        Console.WriteLine(" ▐▐▀▌▐▀▌▌ ▐▐▀▌▐▀▌▌ ▐▐▀▌▐▀▌▌ ");
        Console.WriteLine(" ▐▐▄▌▐▄▌▌ ▐▐▄▌▐▄▌▌ ▐▐▄▌▐▄▌▌ ");
        Console.WriteLine(" ▐     -▌ ▐     -▌ ▐     -▌ ");
        Console.WriteLine(" ▐▐▀▌▐▀▌▌ ▐▐▀▌▐▀▌▌ ▐▐▀▌▐▀▌▌ ");
        Console.WriteLine(" ▐▐▄▌▐▄▌▌ ▐▐▄▌▐▄▌▌ ▐▐▄▌▐▄▌▌ ");
        Console.WriteLine(" ▐▄▄▄▄▄▄▌ ▐▄▄▄▄▄▄▌ ▐▄▄▄▄▄▄▌ ");
        Console.WriteLine("────────────────────────────");
        if(DupeDoor == 1){
       //Console.WriteLine($"    {room+d1}       {room}       {room}    ");
        }else if(DupeDoor == 2){
       //Console.WriteLine($"    {room}       {room+d2}       {room}    ");
        }if(DupeDoor == 3){
       //Console.WriteLine($"    {room}       {room}       {room+d3}    ");
        }
       try {
        input = Console.ReadLine();
        if (int.TryParse(input, out int playerChoice))
        {
            if (playerChoice < 4 && playerChoice > 0)
            {
                if (playerChoice == DupeDoor)
                {
                    health-=40;
                    if(health > 0){

                    Console.WriteLine($"You take 40 damage. Current Health: {health}");
                    Thread.Sleep(1000);
                    GotDuped = true;
                    }else{
                        Console.Clear();
                        for(i = 0; i<YouDied.Length; i++){
                        Console.Write($"{YouDied[i]}");
                        Thread.Sleep(125);
                        }
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The door unlocks with a click");
                    Console.ReadLine();
                    GotDuped = false;
                    room++;
                }
                }
            }
            else
            {
                Console.WriteLine("That's not a door.");
            }
       
        }catch{
            Console.WriteLine("Sorry, I didn't catch that, which door did you choose?");
            continue;
        }
    }
                        Console.Clear();
                        for(i = 0; i<YouWin.Length; i++){
                        Console.Write($"{YouWin[i]}");
                        Thread.Sleep(125);
                        }
                        Environment.Exit(130);
}
}