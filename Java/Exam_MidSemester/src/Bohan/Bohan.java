package Bohan;

import java.util.*;

import java.util.concurrent.ThreadLocalRandom;

/**
 * This class represents a skeleton for the mid-term of Intro2CS course (Ariel U. CS).
 * Please implement the static functions below.
 */

public class Bohan {

	public static void main(String[] args) {
		String[] strings1 = new	String[]{"aa", "b", "ccc", "b"};
		String[] strings2 = new String[]{"aa", "b", "ccc"};
		System.out.println("Test 1: " + stringArr2Set(strings1).length + "\n");

		double[] arr1 = new double[]{1,3,5,3,2,4};
		double[] arr2 = new double[]{2,2.1};

		System.out.println("Test 2.1: " + maxMonotoneIncArr(arr1));
		System.out.println("Test 2.2: " + maxMonotoneIncArr(arr2) + "\n");


	}

	public static String myID = "325112738"; // make sure you update your ID.

	public static String[] stringArr2Set(String[] a) {
		Set<String> temp = new LinkedHashSet<String>( Arrays.asList( a ) );
		String[] result = temp.toArray( new String[temp.size()] );
		return result;
	}

	public static int maxMonotoneIncArr(double[] a) {
		int counter = 0;
		int maxCounter = 0;

		for (int i = 1; i < a.length; i++) {

			if (a[i] > a[i-1])
				counter++;
			else
				counter = 0;
			if (counter == 1) counter = 2;
			if (counter > maxCounter)
				maxCounter = counter;
		}

		return maxCounter;
	}

	public static int sumOf2() {
		int rand1 = ThreadLocalRandom.current().nextInt(1, 6 + 1);
		int rand2 = ThreadLocalRandom.current().nextInt(1, 6 + 1);

		int sum = rand1 + rand2;

		return sum;
	}

	public static double evenSumProb() {
		int sum = 0;

		for (int i = 0; i < 1000; i++) {

			if (sumOf2() % 2 == 0)
				sum += 1;
		}

		double prob = sum / 1000.0;

		return prob;
	}

	public static int intersectionSetSize(int[][] a, int[][] b) {
		int counter = 0;

		for (int i = 0; i < a.length; i++) {

			for (int j = 0; j < a[i].length; j++) {

				for (int m = 0; m < b.length; m++) {

					for (int l = 0; l< b[m].length; l++) {

						if (a[i][j] == b[m][l])
							counter += 1;
					}
				}
			}
		}

		return counter;
	}
}
