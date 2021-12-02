List<int> multipliers = new List<int>();
for (int i = 0; i < 1000; i++)
{
	if (i % 3 == 0 || i % 5 == 0)
		multipliers.Add(i);
}
int sum = 0;
foreach (int i in multipliers)
	sum += i;
Console.WriteLine(sum);