package tvKumandasý;

public class TvKapatKomutu implements Komut
{
private Televizyon tv = null;
public TvKapatKomutu(Televizyon tv)
{
	this.tv = tv;
}
public void execute()
{
this.tv.kapat();
}


}
