package mementoversion2;

import java.util.List;
import java.util.ArrayList;
class Originator {
    private String state;

    public void set(String state) {
        this.state = state;
        System.out.println("Originator: Durum " + state + " 'e ayarlanıyor..");
    }
 
    public Memento saveToMemento() {
        System.out.println("Originator: Memento 'ya kaydedildi.");
        return new Memento(this.state);
    }
 
    public void restoreFromMemento(Memento memento) {
        this.state = memento.getSavedState();
        System.out.println("Originator: Memento 'dan geri alındıktan sonra durum : " + state);
    }
 
    public static class Memento {
        private final String state;

        public Memento(String stateToSave) {
            state = stateToSave;
        }
        private String getSavedState() {
            return state;
        }
    }
}
 
class Caretaker {
    public static void main(String[] args) {
        List<Originator.Memento> savedStates = new ArrayList<Originator.Memento>();
 
        Originator originator = new Originator();
        originator.set("State1");
        originator.set("State2");
        savedStates.add(originator.saveToMemento());
        originator.set("State3");
        savedStates.add(originator.saveToMemento());
        originator.set("State4");
        originator.set("State5");
        originator.set("State6");
        originator.set("State7");
        originator.set("State8");
        savedStates.add(originator.saveToMemento());
        originator.set("State9");
        
        originator.restoreFromMemento(savedStates.get(2));   
    }
}