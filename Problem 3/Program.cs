// https://projecteuler.net/problem=3
long input = 600851475143;

// Skipping ahead to division by 3 as the number is uneven.
for (int i = 3; i < Math.Sqrt(input)+1; i+=2)
{
	while (input % i == 0)
	{
	
		input = input / i;
	}
	if (CheckIfPrime(input))
		Console.WriteLine(input);
}

bool CheckIfPrime(long num)
{
	bool isPrime = true;
	var possibleFactors = Math.Sqrt(num);
	for (var factor = 2; factor <= possibleFactors; factor++)
	{
		if (num % factor == 0)
			isPrime = false;
	}
	return isPrime;
}

