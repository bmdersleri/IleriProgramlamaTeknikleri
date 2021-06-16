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
public class tasit {
    
    private String marka;
    private int model;

    public String getMarka() {
        return marka;
    }

    public void setMarka(String marka) {
        this.marka = marka;
    }

    public int getModel() {
        return model;
    }

    public void setModel(int model) {
        this.model = model;
    }
    
    public void tasityazdir(){
    
        System.out.println("---Tasit Bilgileri---");
        System.out.println("Marka: " + marka);
        System.out.println("Model: " + model);
    }
    
}
