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
public class Kalıtım {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        otomobil otomobil1 = new otomobil();
        
        otomobil1.setMarka("Fiat");
        otomobil1.setModel(2005);
        otomobil1.setYolcusayisi(5);
        otomobil1.setMaxhiz(150);
        
        otomobil1.tasityazdir();
        otomobil1.otomobilyazdir();
        
    }
    
}
