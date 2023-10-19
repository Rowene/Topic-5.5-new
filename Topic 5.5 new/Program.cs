namespace Topic_5._5_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'Enter' to proceed.");
            Console.WriteLine();
            Console.WriteLine("Welcome to John Dear Casino.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You start with $100.");
            Console.WriteLine("To play, Bet on what you think the role will be.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("There are 4 betting options.");
            Console.WriteLine();
            Console.WriteLine("Doubles, if you roll the same number on both die, you get your bet x2.");
            Console.ReadLine();
            Console.WriteLine("Not Doubles, if you dont get the same number, you get half your bet.");
            Console.ReadLine();
            Console.WriteLine("Even Sum, if the sum of the die are even you win your bet.");
            Console.ReadLine();
            Console.WriteLine("Odd Sum, if the sum of the die are off you win your bet");
            Console.ReadLine();

            bool leave = false;
            string betOption;
            double balance = 100;
            double bet = 0;
            bool validBet = false;
            while (leave == false)
            {
                while (validBet == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("How much money do you want to bet? $" + Math.Round(balance, 2));
                    Console.WriteLine("Enter '0' to leave casino.");
                    bet = Convert.ToDouble(Console.ReadLine());
                    if ((bet > balance) || (bet < 0)) { Console.WriteLine(); Console.WriteLine("Invalid"); }
                    else if (bet == 0) { leave = true; validBet = true; }
                    else { validBet = true; }
                    Console.WriteLine();
                }
                validBet = false;
                Console.WriteLine();
                if (leave == false)
                {
                    Console.WriteLine("What do you want to bet on? $" + bet);
                    Console.WriteLine();
                    Console.WriteLine("Type 'D' for Doubles. x3");
                    Console.WriteLine("Type 'N' for Not Doubles. x1.5");
                    Console.WriteLine("Type 'E' for Even Sum. x2");
                    Console.WriteLine("Type 'O' for Odd Sum. x2");
                    betOption = Console.ReadLine();
                    Console.WriteLine();
                    if ((betOption == "D") || (betOption == "d"))
                    {
                        Console.WriteLine();
                        Die die1 = new Die(); Die die2 = new Die();
                        die1.DrawRoll(); die2.DrawRoll();
                        Console.WriteLine();
                        if (die2.Roll == die1.Roll)
                        {
                            Console.WriteLine("Wow,impressive, you won the bet, you recieved $" + bet * 2);
                            balance += (2 * bet);
                        }
                        else
                        {
                            Console.WriteLine("You lost the bet, the dice were not the same. you lost $" + bet);
                            balance -= bet;
                        }
                    }

                    else if ((betOption == "N") || (betOption == "n"))
                    {
                        Console.WriteLine();
                        Die die1 = new Die(); Die die2 = new Die();
                        die1.DrawRoll(); die2.DrawRoll();
                        Console.WriteLine();
                        if (die2.Roll == die1.Roll)
                        {
                            Console.WriteLine("You lost the bet, the dice were the same, you lost $" + bet);
                            balance -= bet;
                        }
                        else
                        {
                            Console.WriteLine("Wow, impressive, you won the bet, you recieved $" + bet / 2);
                            balance += (bet / 2);
                        }
                    }

                    else if ((betOption == "E") || (betOption == "e"))
                    {
                        Console.WriteLine();
                        Die die1 = new Die(); Die die2 = new Die();
                        die1.DrawRoll(); die2.DrawRoll();
                        Console.WriteLine();
                        if ((die1.Roll + die2.Roll) % 2 == 0)
                        {
                            Console.WriteLine("You won the bet, you rolled an even sum, you recieved $" + bet);
                            balance += bet;
                        }
                        else
                        {
                            Console.WriteLine("The sum wasn't even, you lost the bet. Good luck next time.");
                            balance -= bet;
                        }
                    }

                    else if ((betOption == "O") || (betOption == "o"))
                    {
                        Console.WriteLine();
                        Die die1 = new Die(); Die die2 = new Die();
                        die1.DrawRoll(); die2.DrawRoll();
                        Console.WriteLine();
                        if ((die1.Roll + die2.Roll) % 2 == 0)
                        {
                            Console.WriteLine("The sum wasn't odd, you lost the bet. Good luck next time.");
                            balance -= bet;
                        }
                        else
                        {
                            Console.WriteLine("You won the bet, you rolled an odd sum, you recieved $" + bet);
                            balance += bet;
                        }
                    }
                }

                if (balance == 0) { leave = true; }
            }
            Console.WriteLine("I hope you enjoyed your stay, come back again.");
            Console.WriteLine("You ended up with $" + Math.Round(balance, 2));
            Console.ReadLine();
        }
    }
}