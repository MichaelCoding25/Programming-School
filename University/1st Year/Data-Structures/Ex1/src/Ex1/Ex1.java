public class Ex1 {

	public static boolean pairs(int[] a, int s) {
		int[] cp = new int[a.length];

		for (int i = 0; i < a.length; i++) {
			cp[i] = s - a[i];
		}

		int f = a.length - 1;
		for (int i = 0; i < a.length; i++) {
			if (i >= f)
				break;
			while (a[i] + a[f] > s) {
				f -= 1;
				if (i >= f)
					break;
			}
			if (a[i] + a[f] == s) {
				return true;
			}
		}

		return false;
	}

	public static boolean triples(int[] a, int s) {
		for (int i = 0; i < a.length - 1; i++) {
			int[] cp = new int[a.length - 1 - i];

			for (int j = 0; j < a.length - 1 - i; j++) {
				cp[j] = cp[i + 1 + j];
			}

			if (pairs(cp, s - a[i]))
				return true;
		}

		return false;
	}

}
