package mediator;

import java.math.BigDecimal;

public  abstract class Halci {
    private String adi;
    private EnumUrun urun;
    private BigDecimal fiyat;

    private Araci araci;

    public Halci (String adi, EnumUrun urun, BigDecimal fiyat , Araci araci ) {
        this.adi=adi;
        this.urun=urun;
        this.fiyat=fiyat;
        this.araci=araci;
    }
    public void urunAl(){
        araci.halSat(this);
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
