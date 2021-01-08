package ex4.geometry;

import ex4.Ex4_Const;

import java.awt.*;

/**
 * This class represents a 2D segment on the plane, 
 * Ex4: you should implement this class!
 * @author I2CS
 *
 */
public class Segment2D implements GeoShape{
	private Point2D _point1, _point2;

	public Segment2D(Point2D point1, Point2D point2) {
		_point1 = point1;
		_point2 = point2;
	}

	public Segment2D(double x1, double y1, double x2, double y2) {
		_point1 = new Point2D(x1, y1);
		_point2 = new Point2D(x2, y2);
	}

	@Override
	public boolean contains(Point2D ot) {
		return false;
	}

	@Override
	public Point2D centerOfMass() {
		return null;
	}

	/**
	 */
	@Override
	public double area() {
		return 0;
	}

	@Override
	public double perimeter() {
		return -1;
	}

	@Override
	public void move(Point2D vec) {;
	}

	@Override
	public GeoShape copy() {
		return null;
	}
	@Override
	public Point2D[] getPoints() {
		return null;
	}
	@Override
	public String toString() {
		return null;
	}
}