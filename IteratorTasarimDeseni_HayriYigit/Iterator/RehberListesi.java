package BMDersleri_IteratorTasarimDeseni;

import java.util.ArrayList;
import java.util.Hashtable;

// COLLECTION
public interface RehberListesi<E> {
    Rehber<E> tarihiYerRehberi(Hashtable<Integer, GezilecekYer> tarihiYerListesi);
    Rehber<E> lokantaRehberi(ArrayList<GezilecekYer> lokantaListesi);
}


