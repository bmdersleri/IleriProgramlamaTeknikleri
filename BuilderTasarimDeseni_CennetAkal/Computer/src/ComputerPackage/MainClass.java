package ComputerPackage;

public class MainClass {
	 public static void main(String[] args) {
	        final ComputerBuilder computerBuilder = new ComputerBuilder();

	        final Computer computer1 = computerBuilder
	                .setBrand("ASUS")
	                .setCpu("2,40 GHZ")
	                .setPrice("1500 $")
	                .setRam("8 GB")
	                .buildComputer();

	        System.out.println(computer1);

	        final Computer computer2 = computerBuilder
	                .setBrand("APPLE")
	                .setCpu("2,60 GHZ")
	                .setPrice("3500 $")
	                .setRam("16 GB")
	                .buildComputer();

	        System.out.println(computer2);
	    }

}
