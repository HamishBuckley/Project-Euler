<Query Kind="Program" />

void Main()
{
int user_input = Convert.ToInt32(Console.ReadLine());
List<int> output_list = new List<int>();
is_prime(35).Dump();
List<int> factors_list = factors(user_input);
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
public bool is_prime(int number){
		for (int i = 2; i <= (number / 2); i++){
			if (number % i == 0){
				return false;
				}
			}
		return true;
		}
public List<int> factors(int input_number){
	List<int> factors = new List<int>();
	for (int i = 1; i <= (input_number / 2); i++){
		if (input_number % i == 0){
			factors.Add(i);
		}
	}
	return factors;
}