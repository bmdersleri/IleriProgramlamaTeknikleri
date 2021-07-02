/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkgsuper;

/**
 *
 * @author erkut
 */
public class Super {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        otomobil otomobil1 = new otomobil("Fiat", 2005);
        tasit tasit1 = new tasit("bmw", 2010);
        
        tasit1.tasityazdir();
        otomobil1.tasityazdir();
    }
    
}
