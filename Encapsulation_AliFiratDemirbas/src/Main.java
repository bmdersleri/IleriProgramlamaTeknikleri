
public class Main {

	public static void main(String[] args) {
		
		Car car1 = new Car();
		
		car1.setColor("Beyaz");
		car1.setModel("E92 M3");
		car1.setEngine(4.0);
		car1.setDoors(2);
		
		
		System.out.println("Arabanin rengi:" + car1.getColor());
		System.out.println("Arabanin modeli:" + car1.getModel());
		System.out.println("Arabanin motor hacmi:" + car1.getEngine());
		System.out.println("Arabanin kapi sayisi:" + car1.getDoors());

	}

}
