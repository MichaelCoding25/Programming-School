Program Name: Ex1
Author: Michael Spector 325112738
Date: 6/11/2020


Description of algorithm:
The algorithm gets 2 natural numbers and finds the greatest prime common divisor. The algorithm works by finding the GCD of the numbers, then finding the greatest prime factor of that GCD, and printing the GPCD.

Dependencies: package com.company

------------------------------------------------
Pseudo Code:

{
In the main function

	if there are not enough or no arguments brough from command line then
	{
		Receive 2 numbers from user
		Catch any errors and display error message
	}
	else
	{
		check arguments brought from command line and make sure they are valid
		if they are valid then
			input arguments into variables
		else
			display error message
	}
	
	if variables num1 and num2 are valid then
	{
		loop over all numbers from 1 until the lowest of num1 and num2
			find the greatest common divider using an if statement
			
		if find GCD then
		{
			loop until gcd becomes an odd number and set GPCD to 2
			
			loop from 3 until the square root of gcd
				find the greatest prime common divider
				
			make sure that gcd isn't 2, if it is set the GCPD to 2
			
			print result (GCPD)
		}
	}
}