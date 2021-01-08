// package Ex1;

import java.util.Scanner; // Import scanner library

public class Ex1 {

    public static void main(String[] args) {
        long num1 = 0, num2 = 0;
        boolean valid = true;
        if (args.length == 0 || args.length == 1) { // If there are no or not enough args, receive manually
            Scanner myScanner = new Scanner(System.in); // Create a Scanner object

            try {
                System.out.println("Enter the first number for max prime GCD: ");
                num1 = myScanner.nextInt(); // Receive 1st number from user

                System.out.println("Enter the second number for max prime GCD: ");
                num2 = myScanner.nextInt(); // Receive 2nd number from user
                System.out.println("");
            }
            catch (Exception e){ // If there was an error (for example a non int was inputted)
                System.out.printf("ERROR: One or both of the arguments you entered are not integers, please" +
                        " run the program again with correct parameters (Natural Numbers).");
                valid = false;
            }

            myScanner.close(); // Closes scanner object
        }
        else { // If there are enough args
            if (args[0].matches("[0-9]+") && args[1].matches("[0-9]+")) { // Checks if the args are numbers
                num1 = Long.parseLong(args[0]);
                num2 = Long.parseLong(args[1]);
            }
            else {
                System.out.printf("ERROR: One or both of the arguments you entered are not integers, please run the program" +
                        " again with correct parameters (Natural Numbers).");
                valid = false;
            }
        }
        long gcd = -1;
        if (valid == true) { // Check if nums are valid, if not, skip
            for (long i=1; i<=num1 && i<=num2; i++) { // For loop until the lower of the 2 nums
                if (num1%i==0 && num2%i==0) { // Find a common divider
                    gcd = i; // Assign common divider to gcd
                }
            } // Closes for and here we have the GCD

        }

        long gpcd = -1;
        if (gcd != -1) { // Make sure that gcd is valid, if not, skip
            while (gcd % 2 == 0) { // While loop to add 2 to GPCD
                gpcd = 2;
                gcd /= 2;
            }
            for (long i = 3; i <= Math.sqrt(gcd); i +=2) { // Add the rest of the prime dividers of the gcd
                while (gcd % i == 0) { // Check if the number actually divides
                    gpcd = i;
                    gcd /= i;
                }
            }
            if (gcd > 2) // If number at the end is higher than 2, it is the GPCD
                gpcd = gcd;

            System.out.println("Computes the GPCD("+num1+","+num2+") =");
            if (gpcd > 0) {
                System.out.println("Max Prime Common Divider: " + gpcd);
            }
            else if (gpcd == -1) {
                System.out.println("Max Prime Common Divider: " + 0);
            }
            else {
                System.out.println("Max Prime Common Divider: " + 1);
            }
        }
    }
}
