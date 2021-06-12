package BMDersleri_IteratorTasarimDeseni;

import java.util.ArrayList;

// CONCRETE ITERATOR
public class LokantaRehberi implements Rehber<GezilecekYer>{
    ArrayList<GezilecekYer> lokantalar;
    int durakSayac = 0;

    public LokantaRehberi(ArrayList<GezilecekYer> lokantalar) {
        this.lokantalar = lokantalar;
    }

    @Override
    public GezilecekYer sonraki() {
        if(dahaVarMi())
            return lokantalar.get(durakSayac++);
        else
            return null;
    }

    @Override
    public GezilecekYer simdiki() {
        return lokantalar.get(durakSayac);
    }

    @Override
    public boolean dahaVarMi() {
        return durakSayac < lokantalar.size();
    }
}


