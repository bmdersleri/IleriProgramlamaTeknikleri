package ComputerPackage;

public class ComputerBuilder {
	 private String brand;
	    private String price;
	    private String cpu;
	    private String ram;

	    public ComputerBuilder setBrand(final String brand) {
	        this.brand = brand;
	        return this;
	    }

	    public ComputerBuilder setPrice(final String price) {
	        this.price = price;
	        return this;
	    }

	    public ComputerBuilder setCpu(final String cpu) {
	        this.cpu = cpu;
	        return this;
	    }

	    public ComputerBuilder setRam(final String ram) {
	        this.ram = ram;
	        return this;
	    }

	    public Computer buildComputer() {
	        return new Computer(brand, price, cpu, ram);
	    }
}
