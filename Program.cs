using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score: ");

            
            Boolean validData = false;


            while(!validData){

                                    
            String num = Console.ReadLine();
            int score;
            if(int.TryParse(num,out score)){
    if(score>20 || score<0){
            
               Console.WriteLine("your input is out of condition, please enter the valid number");
            
              }else{
                

               if(score<=10){
                               Console.WriteLine("failed");

               }else if(10<score && score<=15){
                                               Console.WriteLine("C");

               }else if (score>15 && score<=17 ){
                                               Console.WriteLine("B");

               }else{
                                                               Console.WriteLine("A");

               }
    int percent = score*5;
                                                               Console.WriteLine("you get "+percent+"% of all");

               validData = true;
                             }
            }else{
                Console.Write("enter a number. input cant be empty. please enter a valid number :  ");
                validData = false;

            }}
          

    




       }
    }
}