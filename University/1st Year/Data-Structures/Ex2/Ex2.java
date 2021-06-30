package Matala;

import java.util.LinkedList;
import java.lang.Math.*;

public class Ex2 {

	
	public static void mergeSort2(int[] arr) {
		int size, l;
		
		for (size = 1; size <= arr.length-1; size *= 2) {
			for (l = 0; l < arr.length-1, l = size * 2) {
				int m = Math.min(l + size - 1, arr.length - 1);
				int r = Math.min(l + size * 2 - 1, arr.length - 1);
				
				int n1 = m - l + 1;
				int n2 = r - m;
				
				int l_arr[] = new int[m - l + 1];
				int r_arr[] = new int[r - m];
				
				for (int i = 0; i < m - l + 1; i++)
					l_arr[i] = arr[l + i];
				for (int i = 0; i < r - m; i++)
					r_arr[i] = arr[m + i + 1];
				
				int i=0, j=0, k=l;
				while (i < m - l + 1 && j < r - m) {
					if (l_arr[i] < r_arr[j]) {
						arr[k] = l_arr[i];
						i++;
					} else {
						arr[k] = r_arr[j];
						j++;
					}
					k++;
				}
				
				while (i < m - l + 1) {
					arr[k] = l_arr[i];
					i++;
					k++;
				}
				
				while (j < r - m) {
					arr[k] = l_arr[j];
					j++;
					k++;
				}	
			}
		}
	}
	
	public static void merge(int[] arr, int low, int mid, int high, int max_num) {
		int[] arr1 = new int[mid - low];
		int[] arr2 = new int[high - mid+1];
		for (int i = arr2.length-1; i>=0; i--) {
            int j, last = arr1[arr1.length-1];
            for (j=arr1.length-2; j >= 0 && arr1[j] > arr2[i]; j--)
                arr1[j+1] = arr1[j];
      
            if (j != arr1.length-2 || last > arr2[i])
            {
                arr1[j+1] = arr2[i];
                arr2[i] = last;
            }
        }
		
		for (int i=0; i < arr1.length; i+=1)
			arr[i] = arr1[i];
		
		for (int i=0; i < arr2.length; i+=1)
			arr[arr1.length + i] = arr2[i];
	}
	
	public static LinkedList<Integer> join(LinkedList<Integer>[] arr) {
		LinkedList<Integer> merged = new
		for (int i = 0; i < arr.length - 1; i++) {
			
		}
		return null;
	}
	
	public static int diff(int[] arr) {
		int first, second;
		
        if (arr[0] > arr[1])
        {
            first = arr[0];
            second = arr[1];
        }
        else
        {
            first = arr[1];
            second = arr[0];
        }
      
        for (int i = 2; i < arr.length; i++)
        {
            if (arr[i] > first)
            {
                second = first;
                first = arr[i];
            }
      
            else if (arr[i] > second && arr[i] != first)
                second = arr[i];
        }
        return (first + second);
	}
}

