//init
Console.Clear();
#nullable disable



//input
MainMenu();

static void MainMenu(){
    Console.Clear();

    Console.WriteLine("Dice Roll Simulator Menu");
    Console.WriteLine("1. Roll Dice Once");
    Console.WriteLine("2. Roll Dice 5 Times");
    Console.WriteLine("3. Roll Dice 'n' Times");
    Console.WriteLine("4. Roll Dice until Snake Eyes");
    Console.WriteLine("5. Exit");
    Console.WriteLine("Select an option (1-5):");

    int ans = Convert.ToInt32(Console.ReadLine());

    if(ans == 1){
        //Rolls Dice once
        Console.Clear();

        Roll2DiceOnce();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();

        MainMenu();
    }else if(ans  == 2){
        //Rolls dice 5 times
        RollDiceFiveTimes();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();

        MainMenu();

    }else if(ans == 3){
        //Roll Dice 'n' Times
        RollDiceNTimes();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();

        MainMenu();
    }else if(ans == 4){
        //Snake eyes
        SnakeEyes();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();

        MainMenu();
    }else if(ans == 5){
        Console.Clear();
        Console.WriteLine("See you later!");
    }
}


//Process functions
static int Roll2DiceOnce(){
    int dice1 = diceRoll();
    int dice2 = diceRoll();

    int sumOfDice = dice1 + dice2;
    
    Console.WriteLine($"{dice1}, {dice2} (sum: {sumOfDice})");

    return sumOfDice;
}


static void RollDiceFiveTimes(){
    Console.Clear();

    for(int i = 0; i < 5; i++){
        Roll2DiceOnce();
    }
}


static void RollDiceNTimes(){
    Console.Clear();
    Console.WriteLine("How many times do you want to roll the dice?");
    int times = Convert.ToInt32(Console.ReadLine());
    
    for(int i = 0; i < times; i++){
        Roll2DiceOnce();
    }
    
}


static void SnakeEyes(){
    Console.Clear();
    bool loop = true;

    while(loop){
        int num = Roll2DiceOnce();
        if(num == 2){
            loop = false;
        }
    }
}

//roll dice 1
static int diceRoll(){
    Random rnd = new Random();

    int diceValue = rnd.Next(1,7);
    return diceValue;
}