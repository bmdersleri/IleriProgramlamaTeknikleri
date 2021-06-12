package BMDersleri_IteratorTasarimDeseni;

import java.util.Hashtable;

// CONCRETE ITERATOR
public class TarihiYerRehberi implements Rehber<GezilecekYer> {
    Hashtable<Integer, GezilecekYer> tarihiYerler;
    int durakSayac = 0;

    public TarihiYerRehberi(Hashtable<Integer, GezilecekYer> tarihiYerler) {
        this.tarihiYerler = tarihiYerler;
    }

    @Override
    public GezilecekYer sonraki() {
        if(dahaVarMi())
            return tarihiYerler.get(durakSayac++);
        return null;
    }

    @Override
    public GezilecekYer simdiki() {
        return tarihiYerler.get(durakSayac);
    }

    @Override
    public boolean dahaVarMi() {
        return durakSayac < tarihiYerler.size();
    }
}


