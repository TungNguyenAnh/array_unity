int[] numbers = new int[5];

numbers[0] = 1;
numbers[1] = 3;
numbers[2] = 4;
numbers[3] = 11;
numbers[4] = 6;



int total = 0;

for (int i = 0; i < numbers.Length; i++)
{
    total = total + numbers[i];
}
System.Console.WriteLine(total);

