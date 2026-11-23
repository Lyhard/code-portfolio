int[] Grade = { 2, 5, 5, 3, 4, 2, 5 };
int countFive = 0;
int countTwo = 0;
float sum = 0;
for (int i = 0; i < Grade.Length; i++)
{
    if (Grade[i] == 5)
        countFive++;
    if (Grade[i] == 2)
        countTwo++;
    sum += Grade[i];
}
sum = (float)sum / Grade.Length;
Console.WriteLine($"Кол-во пятёрок: {countFive}");
Console.WriteLine($"Кол-во двоек: {countTwo}");
Console.WriteLine($"Средний балл: {sum}");