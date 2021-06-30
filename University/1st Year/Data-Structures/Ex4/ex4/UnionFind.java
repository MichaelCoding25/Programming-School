package ex4;

import java.awt.Point;

public class UnionFind {
	//Add class properties
	int[] id;
	Point[] elements;
	double angle;
	
	public UnionFind(int size, double angle) {
		// Update your code below
		this.elements = Ex4Utils.generateRandomArray(size);
		this.id = new int[size];
		this.angle = angle;
	}
	public int Find(int p) {
		// Update your code below
		
		return Integer.MAX_VALUE;
	}
	public void doisJoin() {
		// Update your code below
		
	}
	public void Union(int ind1, int ind2) {
		// Update your code below
		
	}

	public void increaseAngle(int d) {
		// Update your code below
		
	}
	
	public void UnionByAngularDist(Point p) {
		// Update your code below
		
	}
}
