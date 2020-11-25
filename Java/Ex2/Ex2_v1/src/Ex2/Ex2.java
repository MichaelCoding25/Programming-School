//package Ex2;


/** This class (Ex2) allows the manipulation of polynomials.
 * @author Michael Spector
 * @ID: 325112738
 *
 */
public class Ex2 {

    public static double f(double[] poly, double x) {// f(x)
        double answer = 0;

        //For loop through poly
        for (int i = 0; i < poly.length; i++) {
            answer += Math.pow(x, i) * poly[i];
        }

        return answer;
    }

    public static String poly(double[] poly) {// returns a String representing the poly polynom.
        String polynom = "";

        // Move backwards through the polynom
        for (int i = poly.length-1; i >= 0; i--) {
            if (poly[i] != 0.0) {
                // Add the poly value to the string
                polynom += poly[i];

                // If it's not the first position which means x!^1
                if (i != 0) {
                    polynom += "x^" + i;
                }

                // Check if not in first position to not add '+' at end of string
                if (i != 0) {
                    polynom += " + ";
                }
            }
        }

        // Return String
        return polynom;
    }

    public static double root(double[] p,double x1,double x2,double eps) {
        // returns a value (x) such that |f(p,x)|<=eps,
        // assumes f(p,x1) * f(p,x2) <=0, see: Bisection_method
        double x = 0;

        if ( Math.abs(x2 - x1) < eps ) // base case
            return (x1 + x1) / 2;
        else { // recursive case
            x = (x1 + x2) / 2;
            if (f(p, x1) * f(p, x) > 0) // on same side
                return root(p, x, x2, eps);
            else // opposite side
                return root(p, x1, x, eps);
        }
    }

    public static double[] add(double[] p1, double[] p2) {// returns a new array representing the polynom of p1+p2
        int size = Math.max(p1.length, p2.length);
        double sum[] = new double[size];

        // Initialize the polynom
        for (int i = 0; i < p1.length; i++) {
            sum[i] = p1[i];
        }

        // Take ever term of first polynom
        for (int i = 0; i < p2.length; i++) {
            sum[i] += p2[i];
        }

        return sum;
    }

    public static double[] mul(double[] p1, double[] p2) {// returns a new array representing the polynom of (p1)*(p2)
        double[] product = new double[p1.length + p2.length - 1];

        // Initialize the polynom
        for (int i = 0; i < p1.length + p2.length - 1; i++)
        {
            product[i] = 0;
        }

        // Multiply two polynoms term by term
        // Take every term of first polynom
        for (int i = 0; i < p1.length; i++)
        {
            // Multiply the current term of first polynom
            // with every term of second polynom
            for (int j = 0; j < p2.length; j++)
            {
                product[i + j] += p1[i] * p2[j];
            }
        }

        return product;
    }

    public static double[] derivative (double[] po) {//returns a new polynom representing the derivative of (po)
        int derLen = po.length - 1;
        double derivativePo[] = new double[derLen];

        // Multiply polynom in next place by next i to get the derivative
        for (int i = 0; i < derLen; i++) {
            derivativePo[i] = po[i + 1] * (i + 1);
        }

        return derivativePo;
    }
}
