import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

class Processor implements Runnable {
    private int id;
    public Processor(int id) {
        this.id = id;
    }
    @Override
    public void run() {
        System.out.println("Baþlýyor: " + id);
        try {
        	  Thread.sleep(5000);
        }
        catch(InterruptedException e) {}
        System.out.println("Tamamlandý: " + id);
    }
}
public class ThreadOrnegi{
    public static void main(String[] args) {
    	 ExecutorService executorService = Executors.newFixedThreadPool(2);
         for (int i = 1; i <= 5; i++) {
             executorService.submit(new Processor(i));
         }
         executorService.shutdown();
         System.out.println("Tüm görevler eklendi.");
         try {
             executorService.awaitTermination(1, TimeUnit.DAYS);
         }catch(InterruptedException e){}
         System.out.println("Tüm görevler tamamlandý.");
     }
}
