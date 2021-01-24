package moed_A_part2;
public class AreaFilter implements ShapeFilter{
	// Update your code below:
	private GeoShape shape;
	public AreaFilter(GeoShape shape) {
		this.shape = shape;
	}
	
	@Override
	public boolean filter(GeoShape s) {
		if (s.area() > this.shape.area())
			return true;
		return false;
	}	
	//-----------------------
}
