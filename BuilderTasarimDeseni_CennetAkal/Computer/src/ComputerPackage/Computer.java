package ComputerPackage;

public class Computer {
	private String brand;
    private String price;
    private String cpu;
    private String ram;

    public Computer(final String brand, final String price, final String cpu, final String ram) {
        this.brand = brand;
        this.price = price;
        this.cpu = cpu;
        this.ram = ram;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(final String brand) {
        this.brand = brand;
    }

    public String getPrice() {
        return price;
    }

    public void setPrice(final String price) {
        this.price = price;
    }

    public String getCpu() {
        return cpu;
    }

    public void setCpu(final String cpu) {
        this.cpu = cpu;
    }

    public String getRam() {
        return ram;
    }

    public void setRam(final String ram) {
        this.ram = ram;
    }

    @Override
    public String toString() {
        return "Computer{" +
                "brand=" + brand +
                ", cpu=" + cpu +
                ", ram=" + ram +
                ", price=" + price +
                '}';
    }
}
