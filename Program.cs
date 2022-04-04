using System;

namespace MethodsTask{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Methods Task");
            TaskSelector();
        }
        
        public static void TaskSelector(){
            Console.WriteLine("Select a task from 1 to 10");
            string input = Console.ReadLine();
            int slctn = Int32.Parse(input);
            Console.WriteLine("You've selected task " + slctn);
            if(slctn == 1) TaskOne();
            else if(slctn == 2) TaskTwo();
            else if(slctn == 3) TaskThree();
            else if(slctn == 4) TaskFour();
            else if(slctn == 5) TaskFive();
            else if(slctn == 6) TaskSix();
            else if(slctn == 7) TaskSeven();
            else if(slctn == 8) TaskEight();
            else if(slctn == 9) TaskNine();
            else if(slctn == 10) TaskTen();
            else{
                Console.WriteLine("Incorrect selection");
                TaskSelector();
            }
            Again();
        }

        public static void TaskOne(){
            SayHello();
        }

        public static void SayHello(){
            Console.WriteLine("Welcome Friends!\nHave a nice day!");
        }

        public static void TaskTwo(){
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Welcome(input);
        }

        public static void Welcome(string pName){
            Console.WriteLine("Welcome friend " + pName + "!\nHave a nice day!");
        }

        public static void TaskThree(){
            Console.WriteLine("Input two numbers to add");
            Console.Write("First: ");
            string input1 = Console.ReadLine();
            int num1 = Int32.Parse(input1);
            Console.Write("Second: ");
            string input2 = Console.ReadLine();
            int num2 = Int32.Parse(input2);
            AddTwoNums(num1, num2);
        }

        public static void AddTwoNums(int n1, int n2){
            int total = n1 + n2;
            Console.WriteLine("The sum of " + n1 + " and " + n2 + " is: " + total);
        }

        public static void TaskFour(){
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            NumOfSpaces(input);
        }

        public static void NumOfSpaces(string input){
            int space = 0;
            for(int i = 0; i < input.Length; i++){
                if(Char.IsWhiteSpace(input[i]))space++;
            }
            Console.WriteLine("There are " + space + " Spaces in " + "'" + input + "'");
        }

        public static void TaskFive(){
            int[] nums = new int[5];
            int count = 0;
            int total = 0;
            Console.WriteLine("Enter five int elements into the array");
            while(count < 5){
                Console.Write("Element - " + count + ": ");
                string input = Console.ReadLine();
                int num = Int32.Parse(input);
                nums[count] = num;
                count++;
            }
            foreach(int i in nums){
                total += i;
            }
            Console.WriteLine("The sum of the elemnts in the array is " + total);
        }

        public static void TaskSix(){
            Console.Write("Enter a number: ");
            string input1 = Console.ReadLine();
            int num1 = Int32.Parse(input1);
            Console.Write("Enter another number: ");
            string input2 = Console.ReadLine();
            int num2 = Int32.Parse(input2);
            IntSwap(num1, num2);
        }

        public static void IntSwap(int n1, int n2){
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("Now the first number is: " + n1 + ", and the second number is: " + n2);
        }

        public static void TaskSeven(){
            Console.Write("Enter base number: ");
            string input1 = Console.ReadLine();
            int b = Int32.Parse(input1);
            Console.Write("Enter the exponent: ");
            string input2 = Console.ReadLine();
            int expon = Int32.Parse(input2);
            ThePower(b, expon);
        }

        public static void ThePower(int b, int expon){
            double total = Math.Pow(b, expon);
            Console.WriteLine("So, the number " + b + " ^(to the power of) " + expon + " = " + total);
        }

        public static void TaskEight(){
            Console.Write("Input number of Fibonacci Series: ");
            string input = Console.ReadLine();
            int num = Int32.Parse(input);
            Fibon(num);
        }

        public static void Fibon(int i){
            int n1 = 0;
            int n2 = 1;
            int temp;
            int count = 0;
            Console.WriteLine("The Fibonacci series of " + i + " is: ");
            while(count < i){
                Console.Write(n1 + " ");
                temp = n2;
                n2 = n1 + n2;
                n1 = temp;
                count++;
            }
        }

        public static void TaskNine(){
            Console.WriteLine("Input a number: ");
            string input = Console.ReadLine();
            int num = Int32.Parse(input);
            if(PrimeOrNo(num) == true)Console.WriteLine(num + " is a prime number");
            else Console.WriteLine(num + " is not a prime number");
        }

        public static bool PrimeOrNo(int i){
            bool CalculatePrime(int num){
                var possibleFactors = Math.Sqrt(i);
                for (var factor = 2; factor <= possibleFactors; factor++){
                    if (num % factor == 0){
                        return false;
                        }
                }
                        return true;
            }
                        return i > 1 && CalculatePrime(i);
        }

        public static void TaskTen(){
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int num = Int32.Parse(input);
            int total = SumOfNum(num);
            Console.WriteLine("The sum of the digits of the number " + num + " is: " + total);
        }

        public static int SumOfNum(int num){
            int total = 0, i;
            while(num > 0){
                i = num%10;
                total = total + i;
                num = num/10;
            }
            return total;
        }

        public static void Again(){
            Console.WriteLine("Select another task y/n?");
            string ans = Console.ReadLine();
            if(ans.ToLower() == "y" || ans.ToLower() == "yes")TaskSelector();
            else if(ans.ToLower() == "n" || ans.ToLower() == "no")Console.WriteLine("Goodbye");
            else{
                Console.WriteLine("Incorrect selection");
                Again();
            }
        }

    }
}