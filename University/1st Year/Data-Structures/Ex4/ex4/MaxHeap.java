package ex4;

import java.util.Arrays;

/**
 *
 * @author Asaly Saed Maximum heap class - Data structures course, Ariel
 *         University - 2020.
 */

public class MaxHeap {
	int[] arr;
	int last;
	int size;

	public MaxHeap(int size) {
		this.size = size;
		arr = new int[size];
		last = -1;
	}

	public boolean Add(int data) {
		if (last == size - 1)
			return false;
		arr[++last] = data;
		Heapify_Up(last);
		return true;
	}

	private void Heapify_Up(int pos) {
		if (pos == 0)
			return;
		int parent = (int) (Math.floor((pos - 1) / 2));
		if (arr[pos] > arr[parent]) {
			swap(arr, pos, parent);
			Heapify_Up(parent);
		}

	}

	private void swap(int[] arr, int from, int to) {
		int tmp = arr[from];
		arr[from] = arr[to];
		arr[to] = tmp;
	}

	public int Delete() {
		if (last != 0) {
			int tmp = arr[0];
			swap(arr, 0, last--);
			Heapify_down(0);
			return tmp;
		} else if (last == 0) {
			int tmp = arr[0];
			last = -1;
			return tmp;
		} else {
			return Integer.MAX_VALUE;
		}
	}

	private void Heapify_down(int pos) {
		int left, right;
		left = 2 * pos + 1;
		right = 2 * pos + 2;
		if ((left == last) && ((arr[pos] < arr[left]))) {
			swap(arr, pos, left);
			return;
		}
		if ((right == last) && (arr[right] > arr[left]) && (arr[pos] < arr[right])) {
			swap(arr, pos, right);
			return;
		} else if ((right == last) && (arr[right] < arr[left]) && (arr[pos] < arr[left])) {
			swap(arr, pos, left);
			return;
		}
		if (left >= last || right >= last) {
			return;
		}
		if ((arr[left] > arr[right]) && (arr[pos] <= arr[left])) {
			swap(arr, pos, left);
			Heapify_down(left);
		} else if (arr[pos] < arr[right]) {
			swap(arr, pos, right);
			Heapify_down(right);
		}
	}

	public static void HeapSort(int[] arr) {
		MaxHeap h = new MaxHeap(arr.length);
		for (int i = 0; i < arr.length; i++) {
			h.Add(arr[i]);
		}
		for (int i = 0; i < arr.length; i++) {
			h.Delete();
			System.out.println(Arrays.toString(h.arr));
		}
		for (int i = 0; i < arr.length; i++)
			arr[i] = h.arr[i];
	}

	public static MaxHeap mergeTwoHeaps(MaxHeap h1, MaxHeap h2) {
		// Update your code below
		// Complexity: O(h1.size + h2.size) = O(n)
		int[] mergedArr = new int[h1.size + h2.size];

		if (h1.size >= 0) System.arraycopy(h1.arr, 0, mergedArr, 0, h1.size);
		if (h2.size >= 0) System.arraycopy(h2.arr, 0, mergedArr, h1.size, h2.size);

		HeapSort(mergedArr);

		MaxHeap merged = new MaxHeap(mergedArr.length);
		for (int j : mergedArr) merged.Add(j);

		return merged;
	}

	public static int[] getMinHeap(MaxHeap h) {
		// Update your code below
		// Complexity: Equals to building a heap = O(n)
		int[] min = h.arr;

		int i = (min.length - 2) / 2;
		while (i >= 0)
			makeMinHeap(min, i--, min.length);

		return min;
	}

	private static void makeMinHeap(int[] arr, int pos, int size) {
		int left = 2 * pos + 1;
		int right = 2 * pos + 2;

		int small = pos;

		if (left < size && arr[left] < arr[pos])
			small = left;
		if (right < size && arr[right] < arr[small])
			small = right;

		if (small != pos) {
			int tmp = arr[pos];
			arr[pos] = arr[small];
			arr[small] = tmp;

			makeMinHeap(arr, small, size);
		}
	}
}