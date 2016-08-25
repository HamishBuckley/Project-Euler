package main;

import  java.lang.StringBuilder;

public class MAIN {

	public static void main(String[] args){
		System.out.print(PalindromeFactorFinder(1));
	}
	
	private static String PalindromeFactorFinder(int input) {
		while (true){
			for (int i = 999; i > 100; i--){
				for (int j = 999; j > 100; j--){
					System.out.println(i);
					if (IsPalindrome(j * i)){
						return Integer.toString(j) + " " + Integer.toString(i);
					}
				}
			}
		}
	}
	private static boolean IsPalindrome(int inputnumber) {
		String inputstring = String.valueOf(inputnumber);
		if (inputstring.length() % 2 == 0){
			
			if ((inputstring.substring(0 , inputstring.length() / 2)).equals((new StringBuilder(inputstring.substring(inputstring.length() / 2, (inputstring.length()))).reverse().toString()))) {
				return true;
			}
		}
		else{
			if (inputstring.substring(0 , (inputstring.length() / 2)).equals(new StringBuilder(inputstring.substring((inputstring.length() / 2) + 1, (inputstring.length()))).reverse().toString())){
				return true;
		}
		}
		return false;
}
}