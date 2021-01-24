package moed_A_part1;
/** 
 * This class is the 'main' answer form of part #1 of Moed_A
 * introduction to Computer Science, Ariel University.
 */
public class Moed_A_part1_answers {
	public static final long _id = 325112738; // Make sure you update you ID!

	public static int s(int d) {return d*2;}
	public static int r(int d) {return d+1;}

	public static void main(String[] args) {
		String str = "(10)";

		int myNum = calc(str);

		System.out.println(myNum);
	}

///////////// Q1 ////////////
	public static int calc(String f) {
		// Update your code below (Q1.1):
		for (int i = 0; i < f.length(); i++) {
			if (f.charAt(i) != '0' && f.charAt(i) != '1' && f.charAt(i) != '2' && f.charAt(i) != '3' && f.charAt(i) != '4' &&
					f.charAt(i) != '5' && f.charAt(i) != '6' && f.charAt(i) != '7' && f.charAt(i) != '8'
					&& f.charAt(i) != '9') {
				f = f.replace(f.charAt(i), ' ');
			}
		}
		f = f.trim();
		int fNum = Integer.parseInt(f);
		return fNum;
		//-----------------------
	}
	public static boolean isForm(String f) {
		// Update your code below (Q1.2): 
		
		return false;
		//-----------------------
	}
	
	///////////// Q2 ////////////
	///////// Q2.1 ///////////
	public static void addSorted(ListInterface l, int data) {
		// Update your code below (Q2.1): 
		for (int i = 0; i<l.size(); i++) {
			if (data <= l.get(i)) {
				l.addAt(data, i);
				return;
			}
			if (data > l.get(i)) {
				if (data < l.get(i+1)) {
					l.addAt(data, i+1);
				}
			}
		}
		//-----------------------
	}
	//////////// Q2.2 ///////////
	public static ListInterface merge(ListInterface l1, ListInterface l2) {
		// Update your code below (Q2.2): 
		ListInterface sorted = new LinkedList();

		for (int i = 0; i<l1.size(); i++) {
			addSorted(sorted, l1.get(i));
		}
		for (int i = 0; i<l2.size(); i++) {
			addSorted(sorted, l2.get(i));
		}
		return sorted;
		//-----------------------
	}
	//////////// Q2.3 ///////////
	public static ListInterface merge(ListInterface[] ll) {
		// Update your code below (Q2.3): 
		
		return null;
		//-----------------------
	}

}
