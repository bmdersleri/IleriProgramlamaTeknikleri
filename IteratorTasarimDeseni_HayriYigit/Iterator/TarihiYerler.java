package BMDersleri_IteratorTasarimDeseni;

import java.util.Hashtable;

public class TarihiYerler {
    Hashtable<Integer, GezilecekYer> tarihiYerler;
    int hashkey = 0;

    public TarihiYerler() {
        this.tarihiYerler = new Hashtable<>();
        yerEkle("Topkapi Sarayi");
        yerEkle("Galata Kulesi");
        yerEkle("Yerebatan Sarnici");
    }

    public void yerEkle(String isim){
        GezilecekYer gezilecekYer = new GezilecekYer(isim);
        this.tarihiYerler.put(hashkey, gezilecekYer);
        hashkey++;
    }

    public Hashtable<Integer, GezilecekYer> getTarihiYerler() {
        return this.tarihiYerler;
    }
}


