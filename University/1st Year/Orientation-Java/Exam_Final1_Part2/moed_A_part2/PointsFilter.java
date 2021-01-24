package moed_A_part2;

public class PointsFilter implements ShapeFilter{
	// Update your code below:
	private Point2D[] points;
	public PointsFilter(Point2D[] points) {
		this.points = points;
	}
	
	@Override
	public boolean filter(GeoShape s) {
		for (int i = 0; i < this.points.length; i++) {
			if (s.contains(this.points[i]) == false) {
				return false;
			}
		}
		return true;
	}
	//-----------------------
}
