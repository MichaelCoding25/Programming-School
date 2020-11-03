package Ex1;

import java.util.Scanner;

public class Ex1 {

    public static void main(String[] args) {
        int num1 = 0, num2 = 0;
        boolean valid = true;
        if (args.length == 0 || args.length == 1) {
            Scanner myScanner = new Scanner(System.in); // Create a Scanner object

            try {
                System.out.print("Enter the first number for max prime GCD (Natural Number): ");
                num1 = myScanner.nextInt();

                System.out.print("Enter the second number for max prime GCD (Natural Number): ");
                num2 = myScanner.nextInt();
                System.out.println("");
            }
            catch (Exception e){
                System.out.printf("ERROR: One or both of the arguments you entered are not integers, please" +
                        " run the program again with correct parameters (Natural Numbers).");
                valid = false;
            }

            myScanner.close();
        } else {
            if (args[0].matches("[0-9]+") && args[1].matches("[0-9]+")) {
                num1 = Integer.parseInt(args[0]);
                num2 = Integer.parseInt(args[1]);
            } else {
                System.out.printf("ERROR: One or both of the arguments you entered are not integers, please run the program" +
                        " again with correct parameters (Natural Numbers).");
                valid = false;
            }
        }
        int gcd = -1;
        if (valid == true) {
            for (int i=1; i<=num1 && i<=num2; i++) {
                if (num1%i==0 && num2%i==0) {
                    gcd = i;
                }
            }

        }

        long gpcd = -1;
        if (gcd != -1) {
            while (gcd % 2 == 0) {
                gpcd = 2;
                gcd /= 2;
            }
            for (int i = 3; i <= Math.sqrt(gcd); i +=2) {
                while (gcd % i == 0) {
                    gpcd = i;
                    gcd /= i;
                }
            }
            if (gcd > 2)
                gpcd = gcd;

            System.out.println("Computes the GPCD(" + num1 + "," + num2 + ") =");
            if (gpcd > 0) {
                System.out.println("Max Prime Common Divider: " + gpcd);
            }
            else
                System.out.println("Max Prime Common Divider: " + 1);
        }
    }
}

