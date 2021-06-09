public interface BP {
   public void accept(BPZiyaretci bpziyaretci);
}

public class Klavye implements BP {

   @Override
   public void accept(BPZiyaretci bpziyaretci) {
      bpziyaretci.visit(this);
   }
}

public class Ekran implements BP {

   @Override
   public void accept(BPZiyaretci bpziyaretci) {
      bpziyaretci.visit(this);
   }
}

public class Fare implements BP {

   @Override
   public void accept(BPZiyaretci bpziyaretci) {
      bpziyaretci.visit(this);
   }
}

public class Bilgisayar implements BP {
	
   BP[] parça;

   public Bilgisayar(){
      parça = new BP[] {new Fare(), new Klavye(), new Ekran()};		
   } 


   @Override
   public void accept(BPZiyaretci bpziyaretci) {
      for (int i = 0; i < parça.length; i++) {
         parça[i].accept(bpziyaretci);
      }
      bpziyaretci.visit(this);
   }
}

public interface BPZiyaretci {
	public void visit(Bilgisayar bilgisayar);
	public void visit(Fare fare);
	public void visit(Klavye klavye);
	public void visit(Ekran ekran);
}
//BPGZ=Bilgisayar Parçaları Görüntüleyici Ziyaretçi
public class BPGZ implements BPZiyaretci {

   @Override
   public void visit(Bilgisayar bilgisayar) {
      System.out.println("Displaying Computer.");
   }

   @Override
   public void visit(Fare fare) {
      System.out.println("Displaying Mouse.");
   }

   @Override
   public void visit(Klavye klavye) {
      System.out.println("Displaying Keyboard.");
   }

   @Override
   public void visit(Ekran ekran) {
      System.out.println("Displaying Monitor.");
   }
}

public class VisitorPattern {
   public static void main(String[] args) {

      BP bilgisayar = new Bilgisayar();
      bilgisayar.accept(new BPGZ());
   }
}

