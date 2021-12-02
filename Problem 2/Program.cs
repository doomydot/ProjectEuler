int a = 0; 
int b = 1; 
int c = 0;
int sum = 0;
while (sum < 4000000)
{
	c = a + b;
	a = b;
	b = c;
	if (c % 2 == 0)
		sum += c;
}

Console.WriteLine(sum);
