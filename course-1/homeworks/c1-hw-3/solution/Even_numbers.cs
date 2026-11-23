Console.Write("Все чётные числа: ");
int[] numbers = new int[20];
for (int k = 1; k <= 20; k++)
{
    if (k % 2 != 0)
        continue;

    Console.Write(k + " ");
}