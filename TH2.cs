using System.Net.WebSockets;

string[] students = { "Christian", "Michael", "Camila",
 "Sienna", "Tanya", "Connor",
 "Zachariah", "Mallory", "Zoe",
  "Emily" };

System.Console.WriteLine("Insert student name: ");
string input_name = Console.ReadLine();

bool isExist = false;

for (int i = 0; i < students.Length; i++)
{
    if (students[i].Equals(input_name))
    {
        System.Console.WriteLine("Position of the students in the list " + input_name + "is: " + (i + 1));
        isExist = true;
        break;
    }
}
if (!isExist)
{
    System.Console.WriteLine("Not found:" + input_name + " in the list!");
}