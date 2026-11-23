
int[] Number = { 2, 5, 7, 1, 5 };
Console.Write("В прямом порядке: ");
for (int i = 0; i < Number.Length; i++)
{
    Console.Write(Number[i] + " ");
}
Console.WriteLine();
Console.Write("В обратном порядке: ");
for (int j = Number.Length - 1; j >= 0; j--)
{
    Console.Write(Number[j] + " ");
}