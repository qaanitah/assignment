using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("-----------------Question 1---------------");
         int counter = 0;

         Console.WriteLine("Enter first number:");
         int x = Int32.Parse (Console.ReadLine());
         Console.WriteLine("Enter second number:");
         int y = Int32.Parse(Console.ReadLine());

         for (int i = x; i <= y; i++)
         {
             if (i % 5 == 0) counter++;
         }
         Console.WriteLine($"{0} numbers found.", counter);

         Console.WriteLine("--------------Question 2-------------");
         int num1 = 0;
         int num2 = 1;
         int sum = 1;
         int count = 0;

         Console.WriteLine(num1);
         while(count < 100)
         {
             sum = num1 + num2;
             num1 =num2;
             num2 = sum;
             Console.WriteLine(num2);
             count++;

    
         }

         Console.WriteLine("------------Question3---------------");
         Console.WriteLine("Enter the 5 numbers");
         double a = double.Parse(Console.ReadLine());
         double b = double.Parse(Console.ReadLine());
         double c = double.Parse(Console.ReadLine());
         double d = double.Parse(Console.ReadLine());
        
         double e = double.Parse(Console.ReadLine());
         
         if ( (a >= b) && (a >= c) && (a >= d) && (a >= e))
         {
             Console.WriteLine($"The Largest number is: {0}" , a);
             return;
         }
         if ( (b >= a) && (b >= c) && (b >= d) && (b >= e) )
         {
             Console.WriteLine($"The Largest number is: {0}" , b);
             return;
         }
         if ( (c >= a) && (c >= b) && (c >= d) && (c >= e) )
         {
             Console.WriteLine($"The Largest number is: {0}", c);
             return;
         }
         if ( (d >= a) && (d >= b) && (d >= c) && (d >= e) )
         {
             Console.WriteLine($"The Largest number is: {0}", d);
             return;
         }
         if ( (e >= a) && (e >= b) && (e >= c) && (e >= d) )
         {
             Console.WriteLine($"The largest number is: {0}", e);
             return;
         }

         Console.WriteLine("-----------------Question 5--------------");
         byte points;
         Console.WriteLine("Enter points between 1 and 9: ");
         points = Convert.ToByte(Console.ReadLine());
         if (points >= 1 && points <=3)
             Console.WriteLine("points multiplied by 10: {0}", points * 10);
         else if (points >= 4 && points <= 6)
             Console.WriteLine("points multiplied by 100: {0}", points * 100);
         else if (points >= 7 && points <= 9)
             Console.WriteLine("points multiplied by 1000: {0}", points * 1000);

             else
               Console.WriteLine("Wrong Input!");
            Console.ReadLine();
            
            Console.WriteLine("-------------Question 6 ------------------");
            Console.WriteLine("Enter your number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }

            Console.WriteLine("------------Question 7------------");
            for (int i = 0; i < 4; i++)
            {
                if(i != 0) Console.WriteLine();

                for (int j = 0; j < 13; j++)
                {
                    switch (i)
                    {
                        case 0: Console.WriteLine("Hearts"); break;
                        case 1: Console.WriteLine("Diamonds"); break;
                        case 2: Console.WriteLine("Spades"); break;
                        case 3: Console.WriteLine("Clubs"); break;
                    }
                }   switch(i)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }
            }   
            Console.WriteLine();  

            Console.WriteLine("----------Question 8--------------");
            int firstN = 0, secondN = 1, thirdN = 0;
            Console.WriteLine("Enter N:");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("0, 1,");
            for(int i = 2; i < length; i++)
            {
                thirdN = firstN + secondN;
                Console.WriteLine("{0},", thirdN);
                firstN = secondN;
                secondN = thirdN;
            }

            Console.WriteLine("---------Question 14----------");
            Console.WriteLine("Enter your number:");
            int h = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(h, 2);
            Console.WriteLine("Result is {0}", binary);

            Console.WriteLine("----------Question 15----------");
            Console.WriteLine("Enter the binary number:");
            int m = Int32.Parse(Console.ReadLine());
            string todecimal = Convert.ToString(Convert. ToInt32(m, 2), 10);
            Console.WriteLine("Result is {0}", todecimal);

            Console.WriteLine("---------Question 16--------------");
            Console.WriteLine("Enter the decimal number");
            int t = Int32.Parse(Console.ReadLine());
            string toDecimal =Convert.ToString(Convert.ToInt32(t, 10), 16);
            Console.WriteLine("Result is {0}",toDecimal);

            Console.WriteLine("-----------Question 17--------------");
            Console.WriteLine("Enter the decimal number");
            int d = Int32.Parse(Console.ReadLine());
            String toDecimal = Convert.ToString(Convert.ToInt32(d,16), 10);
            Console.WriteLine("Result is {o}", toDecimal);

            Console.WriteLine("----------Question 9------------");
            Console.WriteLine("Enter number");
            int f = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int [f, f];
            int row = 0, col = 0, direction = 0;

            for (int i = 1; 1 <= f * f; i++)
            {
                switch(direction)
                {
                    case 0:
                           if (col > f - 1 || matrix [row, col] != 0)
                           {
                               direction = 1;
                               col--;
                               row++;
                           }
                }          break;
            }       case 1:
                           if (row > f -1 || matrix[row, col] != 0)
                           {
                               direction = 2;
                               col--;
                               row--;
                           }
                           break;
                    case 2:
                           if (col < 0 || matrix[row, col] != 0)
                           {
                               direction = 3;
                               row++;
                               col--;
                           }       
                           break;
                    case 3:
                          if (row < 0 || matrix[row, col] != 0)
                          {
                              direction = 0;
                              row++;
                              col++;
                              
                          }        
                          break;

            matrix[row, col] = i;

            switch(direction)
            {
                case 0: col++; break;
                case 1: row++; break;
                case 2: col--; break;
                case 3: row--; break;
            }
         {
         for (int i = 0; i < f; i++)    
         }
            for (int j = 0; j < f; j++)
            {
                if(matrix[i,j] < 10) Console.WriteLine("{0} ", matrix[i, j]);
                else Console.WriteLine("{0}", matrix[i,j]);
            }               
             console.WriteLine();
                
                
             
            
              
             

        }
    }
}
