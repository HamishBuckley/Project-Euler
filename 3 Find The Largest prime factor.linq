<Query Kind="Program" />

void Main()
{
Console.WriteLine("Finds the largest prime factor of n \n What is n?");
long user_input = Convert.ToInt64(Console.ReadLine());
List<long> output_list = new List<long>();
List<long> factors_list = factors(user_input);
for (int i = 1; i < factors_list.Count; i++){
	if (is_prime(factors_list[i])){
		output_list.Add(factors_list[i]);
	}
}
Console.WriteLine(output_list[output_list.Count - 1]);
}

// Define other methods and classes here
public bool is_prime(long number){
		for (long i = 2; i <= (number / 2); i++){
			if (number % i == 0){
				return false;
				}
			}
		return true;
		}
public List<long> factors(long input_number){
	List<long> factors = new List<long>();
	for (long i = 1; i < (Math.Sqrt(input_number)); i++){
		if (input_number % i == 0){
			factors.Add(i);
		}
	}
	for(int n = 0; n < factors.Count(); n++){
		if (!(factors.Contains(input_number / factors[n]))){
			factors.Add(input_number / factors[n]);
		}
	}
	return factors;
}