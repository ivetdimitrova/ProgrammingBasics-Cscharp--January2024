namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

                string sentence = " ";
                double sum = 0;
            if(n1!=0 && n2!=0) 
            {
                switch (symbol)
                {
                    case '+':
                        sum = n1 + n2;
                        if (sum%2==0)
                        {
                            sentence = $"{n1} + {n2} = {sum} - even";
                               
                        }
                        else
                        {
                            sentence = $"{n1} + {n2} = {sum} - odd";
                        }
                        break;
                    case '-':
                        sum = n1 - n2;
                        if (sum%2==0)
                        {
                            sentence = $"{n1} - {n2} = {sum} - even";

                        }
                        else
                        {
                            sentence = $"{n1} - {n2} = {sum} - odd";
                        }
                        break;
                    case '*':
                        sum = n1 * n2;
                        if (sum%2==0)
                        {
                            sentence = $"{n1} * {n2} = {sum} - even";

                        }
                        else
                        {
                            sentence = $"{n1} * {n2} = {sum} - odd";
                        }
                        break;
                    case '/':
                        sum = n1 / n2;
                       sentence = $"{n1} / {n2} = {sum:f2} ";
                        break;
                    case '%':
                        sum = n1 % n2;
                        sentence = $"{n1} % {n2} = {sum} ";
                        break;
                }
            }
            else
            {
                sentence = $"Cannot divide {n1} by zero";
            }
            Console.WriteLine(sentence);
        }
    }
}