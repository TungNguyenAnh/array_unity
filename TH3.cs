int size;
int[] arrays;

//b1: tao 1 mang moi voi do dai tu chon
do
{
    System.Console.WriteLine("enter a size of the arrays: ");
    size = Int32.Parse(Console.ReadLine());
    if (size > 20)

        System.Console.WriteLine("size should not exceed 20");
} while (size > 20);

//b2: nhap cac gia tri phan tu cho mang
arrays = new int[size];
int i = 0;

while (i < arrays.Length)
{
    System.Console.WriteLine("Enter element" + (i + 1) + " : ");
    arrays[i] = Int32.Parse(Console.ReadLine());
    i++;

}

//b3: in ra cac phan tu trong mang
System.Console.WriteLine("Property list: ");
for (int j = 0; j < arrays.Length; j++)
{
    System.Console.WriteLine(arrays[j]);

}

//b4: duyet phan tu trong mang de tim gtln va index 

int max = arrays[0];
int index = 1;
for (int j = 0; j < arrays.Length; j++)
{
    if (arrays[j] > max)
    {
        max = arrays[j];
        index = j + 1;
    }
}
System.Console.WriteLine("So lon nhat trong mang la: " + max + ", o vi tri " + index);