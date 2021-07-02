/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package override;

/**
 *
 * @author erkut
 */
public class otomobil extends tasit {
    
    public otomobil(String marka, int model){
    
        super(marka, model);
    }
    
    @java.lang.Override
        public void tasityazdir(){
        
            System.out.println("---Override yapıldı---");
        }
    
}
