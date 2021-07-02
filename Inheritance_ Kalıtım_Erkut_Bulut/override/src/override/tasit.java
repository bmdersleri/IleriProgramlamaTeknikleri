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
public class tasit {
    
    private String marka;
    private int model;
    
    public tasit(String marka, int model){
    
        this.marka = marka;
        this.model = model;   
    }
    
    public void tasityazdir(){
    
        System.out.println("---Tasit Bilgileri---");
        System.out.println("Marka: " + this.marka);
        System.out.println("Model: " + this.model);
    }
    
}
