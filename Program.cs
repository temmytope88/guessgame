using System;

namespace guessgame
{
    class Program
    
    {
        static void Main(string[] args)
        {   //Random rnd = new Random();
            //int num = rnd.Next(1,11);
            
          Console.WriteLine("welcome to the guess game with 3 levels: Hard, medium and easy");
          Console.WriteLine("Enter your preferred level");
          string difficulty = Console.ReadLine();
          string level = difficulty.ToUpper();
          
          if(level == "EASY"){
              
              Random rnd = new Random();
              int randonNum = rnd.Next(1,11);
             
              int i = 0;
              
              while( i < 6){
                    Console.WriteLine("Please enter a number between 1 and 10");
                    string num =Console.ReadLine();
                    int guess = Convert.ToInt32(num);
                    if(guess == randonNum){
                        Console.WriteLine("You are right");
                        Console.WriteLine("You Win!!!");
                        break; 
                    }
                    if(guess != randonNum){
                         Console.WriteLine("You are wrong, you have "+(5-i)+"guess left");
                    }
                i++;
              }
               
          }
           
            
          if(level == "MEDIUM"){
              
              Random rnd = new Random();
              int randonNum = rnd.Next(1,21);
             
              int i = 0;
              
              while( i < 4){
                    Console.WriteLine("Please enter a number between 1 and 20");
                    string num =Console.ReadLine();
                    int guess = Convert.ToInt32(num);
                    if(guess == randonNum){
                        Console.WriteLine("You are right");
                        Console.WriteLine("You Win!!!");
                        break; 
                    }
                    if(guess != randonNum){
                         Console.WriteLine("You are wrong, you have "+(3-i)+"guess left");
                    }
                i++;
              }
              
          }
           
           
          if(level == "HARD"){
              
              Random rnd = new Random();
              int randonNum = rnd.Next(1,51);
             
              int i = 0;
              
              while( i < 3){
                    Console.WriteLine("Please enter a number between 1 and 50");
                    string num =Console.ReadLine();
                    int guess = Convert.ToInt32(num);
                    if(guess == randonNum){
                        Console.WriteLine("You are right");
                        Console.WriteLine("You Win!!!");
                        break; 
                    }
                    if(guess != randonNum){
                         Console.WriteLine("You are wrong, you have "+(2-i)+"guess left");
                    }
                i++;
              }
              
          }           

        }
    }
}
