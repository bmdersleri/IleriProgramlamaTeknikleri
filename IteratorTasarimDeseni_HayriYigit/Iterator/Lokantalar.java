package BMDersleri_IteratorTasarimDeseni;

import java.util.ArrayList;

public class Lokantalar {
    ArrayList<GezilecekYer> lokantalar;

    public Lokantalar() {
        this.lokantalar = new ArrayList<>();
        yerEkle("Rejans Rus Lokantasi");
        yerEkle("Orient Express");
        yerEkle("Konyali 1897");
    }

    public void yerEkle(String isim){
        GezilecekYer gezilecekYer = new GezilecekYer(isim);
        this.lokantalar.add(gezilecekYer);
    }

    public ArrayList<GezilecekYer> getLokantalar() {
        return lokantalar;
    }
}


