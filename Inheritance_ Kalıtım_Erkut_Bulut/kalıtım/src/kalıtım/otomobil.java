/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kalıtım;

/**
 *
 * @author erkut
 */
public class otomobil extends tasit{
    
    public int maxhiz;
    public int yolcusayisi;

    public int getMaxhiz() {
        return maxhiz;
    }

    public void setMaxhiz(int maxhiz) {
        this.maxhiz = maxhiz;
    }

    public int getYolcusayisi() {
        return yolcusayisi;
    }

    public void setYolcusayisi(int yolcusayisi) {
        this.yolcusayisi = yolcusayisi;
    }
    
    public void otomobilyazdir(){
    
        System.out.println("---Otomobil Bilgileri---");
        System.out.println("Maksimum Hiz: " + maxhiz);
        System.out.println("Yolcu Sayisi: " + yolcusayisi);
    }
    
    
    
    
}
