#include<stdio.h>

int main()
{
	float a, b, x;
	int i;

	printf("Enter 2 numbers (a, b) for the formula ax + b = 0:\n");
	scanf("%f", &a);
	scanf("%f", &b);

	/* Formula: ax + b = 0
	   or: x = -b/a */
	
	if (a == 0 && b == 0)
	{
		printf("\nThere is an infinite number of solutions.\n");
	}
	else if (a == 0 && b != 0)
	{
		printf("\nThere is no solution with these numbers.\n");
	}
	else
	{
		x = -b / a;
		printf("\n");
	}

	for (i = 0; i < 5; i++)
	{
		printf("%d", i);
	}
	
	

	return 0;
}