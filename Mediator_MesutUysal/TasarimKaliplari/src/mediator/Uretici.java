package mediator;

import java.math.BigDecimal;

public  abstract class Uretici {

    private String adi;
    private EnumUrun urun;
    private BigDecimal fiyat;

    private Araci araci;

    public Uretici (String adi, EnumUrun urun,BigDecimal fiyat, Araci araci) {
        this.adi = adi;
        this.urun = urun;
        this.fiyat = fiyat;
        this.araci = araci;
    }
    public void urunSat(){
        araci.ureticidenAl(this);
    }

    public String getAdi() {
        return adi;
    }

    public EnumUrun getUrun() {
        return urun;
    }

    public BigDecimal getFiyat() {
        return fiyat;
    }
}


