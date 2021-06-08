class Avci {
	void avlanma() {
		System.out.println("Hayvan avlandı");
	}
}
class Aslan extends Avci {
	@Override
	void avlanma() {
		System.out.println("Aslan avlandı");
	}
}
class Timsah extends Avci {
	void avlanma() {
		System.out.println("Timsah avlandı");
	}

	void avlanma(String string) {
		System.out.println("Timsah " + string + " avlandı");
	}
}
public class Main {
	public static void main(String[] args) {
		Avci avci = new Avci();
		avci.avlanma();
		Aslan aslan = new Aslan();
		aslan.avlanma();
		Timsah timsah = new Timsah();
		timsah.avlanma();
		timsah.avlanma("geyik");
	}
}