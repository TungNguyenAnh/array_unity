
int[] array = { 1, 2, 3, 4, 5 };

Console.WriteLine("Nhập giá trị cần thêm vào mảng: ");
int value = int.Parse(Console.ReadLine());

Console.WriteLine("Nhập vị trí index cần thêm: ");
int index = int.Parse(Console.ReadLine());

if (index < 0 || index > array.Length)
{
    Console.WriteLine("Vị trí index không hợp lệ!");
    return;
}

int[] newArray = new int[array.Length + 1];

for (int i = 0; i < index; i++)
{
    newArray[i] = array[i];
}

newArray[index] = value;

for (int i = index + 1; i < newArray.Length; i++)
{
    newArray[i] = array[i - 1];
}

// In ra mảng mới
Console.WriteLine("Mảng mới sau khi thêm phần tử: ");
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}

