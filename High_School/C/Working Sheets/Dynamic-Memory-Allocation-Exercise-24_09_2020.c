#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define INC 5

int* myIntRealloc(int* a, int newItemsNum)
{
	int* newMem;
	int i;

	newMem = malloc(newItemsNum * sizeof(int));
	if (newMem == NULL)
	{
		exit(1);
	}
	if (a != NULL)
	{
		for (i = 0; i < newItemsNum - 5; i++)
		{
			newMem[i] = a[i];
		}
	}
	return newMem;
}

int* deleteItems(int* ptr, int* curItems, int n)
{
	int* newMem;
	int* p = ptr;
	int* q = ptr;
	int cnt = 0;

	while (p < (ptr + *curItems))
	{
		if (*p == n)
		{
			p++;
			cnt++;
		}
		else
		{
			*q = *p;
			p++;
			q++;
		}
	}

	*curItems -= cnt;
	newMem = (int*)malloc(*curItems * sizeof(int));
	memcpy(newMem, ptr, *curItems * sizeof(int));
	return newMem;
}

int main()
{
	int *ptr = NULL;
	int *ptrTmp = NULL;
	int curSize = 0;
	int curItems = 0;
	int i;

	int n;


	scanf("%d", &n);
	while (n != -1)
	{
		curItems++;
		if (curItems > curSize)
		{
			curSize += INC;
			ptrTmp = (int*)myIntRealloc(ptr, curSize, sizeof(int));
			(*(ptrTmp + curItems - 1)) = n;
			if (ptr != NULL)
			{
				free(ptr);
			}
			ptr = ptrTmp;
		}
		else
		{
			*(ptr + curItems - 1) = n;
		}
		scanf("%d", &n);
	}

	printArr(ptr, curItems);

	printf("The End");

	ptr = deleteItems(ptr, &curItems, n);

	printArr(ptr, curItems);
	scanf("%d", &n);

	return 0;
}