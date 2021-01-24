package moed_A_part2;

import java.util.Arrays;
/** 
 * This class is the 'main' answer form of part #2 of Moed_A:
 * introduction to Computer Science, Ariel University.
 */
public class Moed_A_part2_answers {
	public static final long _id = 325112738; // Make sure you update you ID!
	
	/////////// Q3 ////////////
	public static String sort(String num){
		// Update your code below (Q3):
		int[] intArray = new int[num.length()];
		String sorted = "";
		for (int i = 0; i < num.length(); i++) {
			if (num.charAt(i) != '0') {
				intArray[i] = Integer.parseInt(num.substring(i, i+1));
			}
		}
		Arrays.sort(intArray);
		for (int i = 0; i < intArray.length; i++) {
			sorted = sorted + String.valueOf(intArray[i]);
		}
		return sorted;
		//-----------------------
	}
	/////////// Q4 ////////////
	public static GeoShape[] ff(GeoShape[] arr, ShapeFilter f){
		// Update your code below (Q4):
		 GeoShape[] mid = new GeoShape[arr.length];
		 int counter = 0;
		 for (int i = 0; i < arr.length; i++) {
			if (f.filter(arr[i]) == true) {
				mid[counter] = arr[i];
				counter += 1;
			}
		 }
		 GeoShape[] finalArr = new GeoShape[counter+1];
		 for (int i = 0; i < finalArr.length; i++) {
		 	finalArr[i] = mid[i];
		 }
		
		return finalArr;
		//-----------------------
	}

}
