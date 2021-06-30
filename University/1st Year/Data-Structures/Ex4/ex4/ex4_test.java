package ex4;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class ex4_test {


    //*****Q1**********

    //return true if the array represent a Max heap
    static boolean isMaxHeap(int arr[])
    {
        int left = 0, right = 0;
        for(int i = 0 ; i <= (arr.length/2) -1; i++){
            left =2*i + 1;
            right = 2*i +2;
            if(left  <= arr.length-1 && arr[left] > arr[i] )
                return false;
            if(right <= arr.length-1 && arr[right] > arr[i])
                return false;

        }
        return true;
    }

    //return true if the array represent a min heap
    static boolean isMinHeap(int arr[]){

        int left = 0, right = 0;
        for(int i = 0 ; i <= (arr.length/2) -1; i++){
            left =2*i + 1;
            right = 2*i +2;
            if(left  <= arr.length-1 && arr[left] < arr[i] )
                return false;
            if(right <= arr.length-1 && arr[right] < arr[i])
                return false;

        }
        return true;

    }

    @Test
    void isMaxheapTest(){

        int a1[] = {1,2,3,4,5,6};
        int a2[] = {1,2};
        assertFalse(isMaxHeap(a1));
        assertFalse(isMaxHeap(a2));

        int[] a3 = {12,10,9,2,5,7,6};
        assertTrue(isMaxHeap(a3));
        int[] a4 = {20,15,8,10,5,7,6,2,9,1};
        assertTrue(isMaxHeap(a4));
    }

    @Test
    void isMinHeapTest(){

        int[] m1 = {1,2,3,4,5,6};
        int[] m2 = {2,3,2};
        int[] m3 = {1,1,1,4,5,2,1};

        assertTrue(isMinHeap(m1));
        assertTrue(isMinHeap(m2));
        assertTrue(isMinHeap(m3));

        int[] n1 = {4,3,2,1};
        int[] n2 = {4,2,11,0};
        assertFalse(isMinHeap(n1));
        assertFalse(isMinHeap(n2));
    }

    @Test
    void mergeTest(){

        MaxHeap m1 = new MaxHeap(5);
        m1.Add(1 );
        m1.Add(2);
        m1.Add(3);
        m1.Add(4);
        m1.Add(5);

        MaxHeap m2 = new MaxHeap(3);
        m2.Add(6);
        m2.Add(7);
        m2.Add(8);



        MaxHeap m3 = MaxHeap.mergeTwoHeaps(m1,m2);
        MaxHeap m4 = MaxHeap.mergeTwoHeaps(m1,m3);
        MaxHeap m5 = MaxHeap.mergeTwoHeaps(m4,m3);

        assertTrue(isMaxHeap(m3.arr));
        assertTrue(isMaxHeap(m4.arr));
        assertTrue(isMaxHeap(m5.arr));

        MaxHeap zero1 = new MaxHeap(2);
        zero1.Add(0);
        zero1.Add(0);
        MaxHeap zero2 = new MaxHeap(1);
        zero2.Add(0);

        MaxHeap z = MaxHeap.mergeTwoHeaps(zero1,zero2);
        assertTrue(isMaxHeap(z.arr));

        //semi-full heaps
        MaxHeap sm = new MaxHeap(8);
        sm.Add(6);
        sm.Add(7);
        sm.Add(8);

        MaxHeap sm1 = new MaxHeap(7);
        sm1.Add(7);
        sm1.Add(3);
        sm1.Add(2);

        MaxHeap sm2 = MaxHeap.mergeTwoHeaps(sm,sm1);
        assertTrue(isMaxHeap(sm2.arr));



    }

    @Test
    void getMinHeapTests(){

        MaxHeap m1 = new MaxHeap(5);
        m1.Add(1 );
        m1.Add(2);
        m1.Add(0);
        m1.Add(11);
        m1.Add(2);

        MaxHeap m2 = new MaxHeap(3);
        m2.Add(6);
        m2.Add(7);
        m2.Add(1);


        MaxHeap.getMinHeap(m2);

        MaxHeap m3 = new MaxHeap(1);
        m3.Add(6);

        MaxHeap m4 = new MaxHeap(5);
        m4.Add(0);
        m4.Add(0);
        m4.Add(0);
        m4.Add(0);
        m4.Add(0);
        MaxHeap m5 = MaxHeap.mergeTwoHeaps(m2,m4);


        assertTrue(isMinHeap(MaxHeap.getMinHeap(m1)));
        assertTrue(isMinHeap(MaxHeap.getMinHeap(m2)));
        assertTrue(isMinHeap(MaxHeap.getMinHeap(m3)));
        assertTrue(isMinHeap(MaxHeap.getMinHeap(m4)));
        assertTrue(isMinHeap(MaxHeap.getMinHeap(m5)));




    }

    //*******Q2********


    @Test
    void q2Test(){

        //case 1: unique partitions of 12
        int []a = {1,2,3,4,5,6,7,8,9,10,11,12};
        int t = 12;
        int[][] exp ={{1,2,9},{1,3,8},{1,4,7},{1,5,6},{2,3,7},{2,4,6},{3,4,5}};

        List<int[]> l = Ex4.ThreeSum(a,t);
        int[][] temp = new int[l.size()][3];
        int counter = 0;

        for(int[] arg: l)
            temp[counter++] = arg;

        assertTrue(isIn(exp,temp));

        //case 2: negative numbers

        int []a1 = {-3,2,7,-300,13};
        int t1 = 12;
        int[][] exp1 ={{-3,2,13}};
        counter = 0;
        List<int[]> l1 = Ex4.ThreeSum(a1,t1);
        int[][] temp1 = new int[l1.size()][3];
        for(int[] arg: l1)
            temp1[counter++] = arg;

        assertTrue(isIn(exp1,temp1));

        //case 3: no results

        int []a2 = {9,2,1,5,-4,11};
        int t2 = 92;
        List<int[]> l2 = Ex4.ThreeSum(a2,t2);
        assertTrue(l2.size() == 0);

        //case 4: zeros - another no results case
        int []a3 = {0,0,0,0,0,0,0};
        int t3 = 92;
        List<int[]> l3 = Ex4.ThreeSum(a3,t3);
        assertTrue(l3.size() == 0);

        //case 5: target = 8

        int []a4 = {2,7,-1,-3,4,3,1};
        int t4 = 8;
        int exp4[][] = {{-1,2,7},{1,3,4},{-3,4,7}};
        List<int[]> l4 = Ex4.ThreeSum(a4,t4);
        counter = 0;
        int[][] temp4 = new int[l4.size()][3];
        for(int[] arg: l4)
            temp4[counter++] = arg;

        assertTrue(isIn(exp4,temp4));

        //case 6: duplicate values
        int []a5 = {2,7,-1,-3,4,3,1,2,7,-1,4,3,1,4,3,1};
        int t5 = 8;
        int exp5[][] = {{-1,2,7},{1,3,4},{-3,4,7}};

        List<int[]> l5 = Ex4.ThreeSum(a4,t4);
        counter = 0;
        int[][] temp5 = new int[l4.size()][3];
        for(int[] arg: l5)
            temp5[counter++] = arg;

        assertTrue(isIn(exp5,temp5));



    }
    static boolean isIn(int exp[][], int result[][]){

        //check if the two groups of arrays are identical

        for(int[] arg: exp){
            if(!(Arrays.stream(result).anyMatch(line -> Arrays.equals(line,arg))))
                return false;
        }

        for(int[] arg: result){
            if(!(Arrays.stream(exp).anyMatch(line -> Arrays.equals(line,arg))))
                return false;
        }

        return true;
    }
}
