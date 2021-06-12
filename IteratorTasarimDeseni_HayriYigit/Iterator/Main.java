package BMDersleri_IteratorTasarimDeseni;

import java.util.ArrayList;
import java.util.Hashtable;
import java.util.Set;

public class Main {
    public static void Gez(Rehber rehber){
        while (rehber.dahaVarMi()){
            GezilecekYer simdikiYer = (GezilecekYer) rehber.sonraki();
            System.out.println("\t"+simdikiYer.getIsim());
        }
    }
    public static void main(String[] args) {
        TarihiYerler tarihiYerler = new TarihiYerler();
        Lokantalar lokantalar = new Lokantalar();

        // Yer listelerini alalim
        Hashtable<Integer, GezilecekYer> tarihiYerListesi = tarihiYerler.getTarihiYerler();
        ArrayList<GezilecekYer> lokantaListesi = lokantalar.getLokantalar();

        RehberListesi<GezilecekYer> rehberCagir = new RehberCagir();

        Rehber<GezilecekYer> tarihiYerRehberi = rehberCagir.tarihiYerRehberi(tarihiYerListesi);
        Rehber<GezilecekYer> lokantaRehberi = rehberCagir.lokantaRehberi(lokantaListesi);

        // ITERATOR
        System.out.println("Lokanta Listesi:");
        Gez(lokantaRehberi);

        System.out.println("Tarihi Yer Listesi:");
        Gez(tarihiYerRehberi);

        // FOR DONGULERI
        System.out.println("Lokanta Listesi:");
        for (GezilecekYer gezilecekYer : lokantaListesi) {
            System.out.println("\t"+ gezilecekYer.getIsim());
        }

        System.out.println("Tarihi Yer Listesi:");
        Set<Integer> gezilecekYerSet = tarihiYerListesi.keySet();
        for(Integer key: gezilecekYerSet){
            System.out.println("\t"+tarihiYerListesi.get(key).getIsim());
        }
    }
}

