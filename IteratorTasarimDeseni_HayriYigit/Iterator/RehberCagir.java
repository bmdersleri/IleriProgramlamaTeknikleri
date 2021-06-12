package BMDersleri_IteratorTasarimDeseni;

import java.util.ArrayList;
import java.util.Hashtable;

// CONCRETE COLLECTION
public class RehberCagir implements RehberListesi<GezilecekYer>{

    @Override
    public Rehber<GezilecekYer> tarihiYerRehberi(Hashtable<Integer, GezilecekYer> tarihiYerListesi) {
        return new TarihiYerRehberi(tarihiYerListesi);
    }

    @Override
    public Rehber<GezilecekYer> lokantaRehberi(ArrayList<GezilecekYer> lokantaListesi) {
        return new LokantaRehberi(lokantaListesi);
    }
}


