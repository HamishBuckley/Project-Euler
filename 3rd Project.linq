<Query Kind="Program" />

void Main()
{
long user_input = Convert.ToInt64(Console.ReadLine());
List<long> output_list = new List<long>();
is_prime(35).Dump();
List<long> factors_list = factors(user_input);
factors_list.Dump();
for (int i = 1; i < factors_list.Count; i++){
	i.Dump();
	if (is_prime(factors_list[i])){
		output_list.Add(factors_list[i]);
	}
}

output_list.Dump();
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
	for (long i = 1; i <= (input_number / 2); i++){
		if (input_number % i == 0){
			factors.Add(i);
		}
	}
	return factors;
}