package composition;

public class Composition {
    
    public class A{
    
        private B _b;
        public void doSomethingUniqeToB(){
        if(null==_b){
        
            _b = new B();
        }
        return _b.doSomething();
        
        }
    }

    public static void main(String[] args) {
       
    }
    
}
