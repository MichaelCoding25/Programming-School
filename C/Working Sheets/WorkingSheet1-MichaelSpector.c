#include<stdio.h>

void q1()
{
	printf("\nQuestion 1:\n");
	/*
		A: 5

		B: 0 - 121212121212122
		   0 - 222222222222222
		  15 - XXXXXXXXXXXXXXX

		C: There is only 1 'X' in the inputs.

		D: From 0 to 15

		E: Out of 15 games, how many are with the result X.

		F: numOfXResults
	*/
}

void q2()
{

	/*
		A: 3,6 - 3+4+5+6 = 18
		  -2,3 - -2+-1+0+1+2+3 = 3
		   4,5 - 4+5 = 9
		   5,4 - 0, because 5 is higher than 4 so the loop won't run.
	*/

	int min, max, sum = 0, i;
	int input1, input2;
	printf("\nQuestion 2 (A):\n");

	printf("\nPlease enter 2 whole numbers, while the first one is smaller than the second one:\n");
	scanf("%d", &min);
	scanf("%d", &max);

	for (i = min; i <= max; i++)
	{
		sum += i;
	}

	printf("\nThe sum of the numbers in between the inputs is: %d\n", sum);

	/*
		C: What I need to change is find the bigger number out of the 2 inputs, and not base
		   it off the order of the user.
	*/

	sum = 0;
	printf("\nQuestion 2 (C):\n");

	printf("\nPlease enter 2 whole numbers:\n");

	scanf("%d", &input1);
	scanf("%d", &input2);

	if (input1 > input2)
	{
		max = input1;
		min = input2;
	}
	else
	{
		max = input2;
		min = input1;
	}

	for (i = min; i <= max; i++)
	{
		sum += i;
	}

	printf("\nThe sum of the numbers in between the inputs is: %d\n", sum);
}

void q3()
{
	int N, min, max, i, tempAge;
	printf("\nQuestion 3:");

	printf("\nEnter number of students:\n");
	scanf("%d", &N);

	printf("\nEnter the age of a student: ");
	scanf("%d", &tempAge);

	min = tempAge;
	max = tempAge;

	for (i = 1; i < N; i++)
	{
		printf("\nEnter the age of a student: ");
		scanf("%d", &tempAge);

		if (tempAge < min)
			min = tempAge;
		else if (tempAge > max)
			max = tempAge;
	}

	if (max - min > 3)
	{
		printf("\nThis group of students is Heterogenic.\n");
	}
	else
	{
		printf("\nThis group of students is Homogenic.\n");
	}

}

void q4()
{
	int N, M, max1, max2, natNum, i;
	printf("\nQuestion 4:\n");

	printf("\nEnter 2 whole number which are bigger than 1:\n");
	scanf("%d", &N);
	scanf("%d", &M);

	printf("\nEnter a natural number:");
	scanf("%d", &natNum);
	max1 = natNum;
	max2 = 0;

	for (i = 1; i < N; i++)
	{
		printf("\nEnter a natural number:");
		scanf("%d", &natNum);

		if (natNum > max2)
		{
			if (natNum > max1)
			{
				max2 = max1;
				max1 = natNum;
			}
			else
			{
				max2 = natNum;
			}
		}
	}

	if (max1 + max2 > M)
	{
		printf("\nThere is a pair of numbers in the ones you entered which their sum is bigger than %d.\n", M);
	}
	else
	{
		printf("\nThere is not a pair of numbers in the ones you entered which their sum is bigger than %d.\n", M);
	}
}

void q5()
{
	printf("\nQuestion 5:\n");
	/*
	  A: The rook is set on a black chess slot.

	  B: bishop_row == rook_row || bishop_col == rook_col

	  C: It does not show all the options:
		(bishop_row – rook_row) == (bishop_col – rook_col) || (rook_row - bishop_row) == (bishop_col - rook col) ||
		(bishop_row – rook_row) == (rook_col - bishop_col) || (rook_row - bishop_row) == (rook_col - bishop_col)
	*/
}

void q6()
{
	printf("\nQuestion 6:\n");
	/*
		A: There is no way for a tie because the loop happens 41 times, meaning 41 votes, which means 1 contestent will receive more votes.

		B: You can use 1 counter because there are only 2 contestents, meaning the votes that did not go to 1 contestent, went to the other one.
	*/

	int counter = 0, vote, i, loops;

	loops = 41;

	for (i = 0; i < loops; i++)
	{
		printf("\nEnter the number of the contestent you would like to vote for (1 or 2):\n");
		scanf("%d", &vote);
		if (vote == 1)
			counter++;
	}

	if (counter > loops - counter) {
		printf("\nContestent number 1 won!\n");
	}
	else
		printf("\nContestent number 2 won!\n");
}

void q7()
{
	int decimal, hours, minutes, seconds;

	printf("\nQuestion 7:\n");

	printf("\nEnter a number between 1 and 86,399: ");
	scanf("%d", &decimal);
	if (decimal > 0 && decimal < 86400)
	{
		hours = decimal / 3600;

		decimal %= 3600;
		minutes = decimal / 60;

		decimal %= 60;
		seconds = decimal;

		printf("\nThe time is: %d:", hours);
		printf("%d:", minutes);
		printf("%d\n", seconds);
	}
	else
		printf("\nYou have entered a wrong input, please relaunch the program and enter a correct value.\n");
}

void q8()
{
	printf("\nQuestion 8:\n");
	/*
		1. They are both the same.
	*/
}

void q9()
{
	printf("\nQuestion 9:\n");
	/*
		3. b, 'c', B, c
	*/
}

void q10()
{
	int a1, q, n, i;

	printf("\nQuestion 10:\n");

	printf("\nPlease enter 3 numbers with one space in between (3rd one natural number): ");
	scanf("%d %d %d", &a1, &q, &n);

	for (i = 0; i < n; i++)
	{
		if (i == n - 1)
			printf("%d", a1);
		else
		{
			printf("%d,", a1);
			a1 *= q;
		}
	}

	printf("\n");
}

void q11()
{
	int limitNum, i, sum = 0;

	limitNum = 1000;

	printf("\nQuestion 11:\n");

	for (i = 1; i < limitNum; i++)
	{
		if (i % 3 == 0 || i % 5 == 0)
		{
			sum += i;
		}

	}

	printf("\nThe sum is: %d\n", sum);
}

void q12()
{
	int a, units, tens, i;

	printf("\nQuestion 12:\n");

	printf("\nEnter a number between 1 and 18: ");
	scanf("%d", &a);

	if (a >= 1 && a <= 18)
	{
		for (i = 10; i < 100; i++)
		{
			units = i % 10;
			tens = i / 10;

			if (units + tens == a)
			{
				printf("%d,", i);
			}
		}

		printf("\n");
	}
	else
		printf("\nYou entered a wrong input, please restart the program and enter a correct number.\n");
}

void q13()
{
	float i, j, numI1Digit, numI2Digit, numJ1Digit, numJ2Digit;

	printf("\nQuestion 13:\n");

	for (i = 10; i < 100; i++)
	{
		for (j = 0; j < 100; j++)
		{
			numI1Digit = (int)((int)i % 10);
			numI2Digit = (int)(i / 10);
			numJ1Digit = (int)((int)j % 10);
			numJ2Digit = (int)(j / 10);

			if (numI1Digit == numJ2Digit && numI2Digit / numJ1Digit == i / j)
			{
				printf("\na: %f, b: %f ", i, j);
			}
		}
	}
}

int main()
{
	q1;

	return 0;
}
