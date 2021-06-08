package tvKumandasý;


public class TvAcKomutu implements Komut
{
private Televizyon tv = null;
public TvAcKomutu(Televizyon tv)
{
this.tv = tv;
}
public void execute()
{
this.tv.ac();
}}