package ex4;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;

public class Ex4 {
    public static List<int[]> ThreeSum(int[] arr, int target) {
        // Update your code below
        // Complexity: 3 nesting loops  = O(n^3)
        HashSet<int[]> sumsHash = new HashSet<>();


        for (int i = 0; i < arr.length; i++) {
            for (int j = i + 1; j < arr.length; j++) {
                for (int k = j + 1; k < arr.length; k++) {
                    if (arr[i] != arr[j] && arr[i] != arr[k] && arr[j] != arr[k]) {
                        if (arr[i] + arr[j] + arr[k] == target) {
                            int min = Math.min(arr[i], Math.min(arr[j], arr[k]));
                            int max = Math.max(arr[i], Math.max(arr[j], arr[k]));
                            int mid = arr[i] + arr[j] + arr[k] - max - min;

                            int[] sumArr = {min, mid, max};
                            sumsHash.add(sumArr);
                        }
                    }
                }
            }
        }

        return new ArrayList<>(sumsHash);
    }

    public static void main(String[] args) {
        // Update your code below (here you can test you solution)
    }
}
