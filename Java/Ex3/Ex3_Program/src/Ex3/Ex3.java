//package Ex3;


/**
 * @author Michael Spector
 * @ID 325112738
 */
public class Ex3 {

    public static String moveCharToLast(String str, char ch) {
        if(str.length() < 1) {
            return "";
        }

        String newString = str.substring(1); //Create new string without first character

        if(str.indexOf(ch) == 0) { //This happens when your character is found
            return moveCharToLast(newString, ch) + ch;
        } else { //This happens with all other characters
            return str.charAt(0) + moveCharToLast(newString, ch);
        }
    }

    public static String reduce(String str) {
        if ( str.length() <= 1 )
            return str;
        if( str.substring(1,2).equals(str.substring(0,1)) )
            return reduce(str.substring(1));
        else
            return str.charAt(0) + reduce(str.substring(1));
    }

    public static boolean mySplit(int[] nums) {
        return true;
    }

    public static int[][] sumOfNeighbours(int[][] mat) {

        int[][] resultMat = new int[mat.length][mat[0].length];
        int sum = 0;

        for (int row = 0; row < mat.length; row++) {

            for (int col = 0; col < mat[row].length; col++) {

                for (int i = -1; i < 2; i++) {

                    for (int j = -1; j < 2; j++) {

                        // skip center cell
                        if (i == j) continue;
                        // skip rows out of range.
                        if ( (i + row) < 0 || (i + row >= mat.length) ) continue;
                        // skip columns out of range.
                        if ( (j + col) < 0 || (j + col >= mat[row].length) ) continue;
                        // add to sum.
                        sum += mat[i + row][j + col];
                    }
                }
                resultMat[row][col] = sum;
            }
        }
        return resultMat;
    }

    public static String caesarCipherText(String str, int key) {
        String result = "";

        if (key > 26 || key < -26)
            return "";

        for (int i=0; i<str.length(); i++) {
            if (str.charAt(i) != ' ') {
                char ch = (char) (((int) str.charAt(i) +
                        key - 97) % 26 + 97);
                result += ch;
            }
            else
                result += ' ';
        }
        return result;
    }

    public static String vigenereCipherText(String str, String key) {
        String encrypted="";
        String key2 = "";

        int keyCounter = 0;

        for (int i = 0; i < str.length(); i++)
        {
            key2 += (key.charAt(keyCounter));
            keyCounter += 1;

            if (keyCounter == key.length())
                keyCounter = 0;
        }

        for (int i = 0; i < str.length(); i++)
        {
            encrypted += caesarCipherText(String.valueOf(str.charAt(i)), key2.charAt(i));
        }
        return encrypted;
    }
    public static String vigenereDecipherText(String str, String key) {
        String decrypted="";

        for (int i = 0 ; i < str.length() &&
                i < key.length(); i++)
        {
            decrypted+=caesarCipherText(String.valueOf(str.charAt(i)), key.charAt(i));
        }
        return decrypted;
    }

    public static String myID() {return "325112738";}
}
