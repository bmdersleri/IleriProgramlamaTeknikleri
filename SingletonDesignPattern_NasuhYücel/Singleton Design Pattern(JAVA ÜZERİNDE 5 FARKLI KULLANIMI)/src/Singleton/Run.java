package ileriFinal;

public class Run {
	
	public static void main(String[] args) {
		
		LazySingleton.getLazySingleton().singletonTest();
		
		EagerInitializationSingleton.getInstance().SingletonTest();
		
		StaticBlockSingleton.getStaticBlockSingleton().singletonTest();
		
		ThreadSafeSingleton.getThreadSafeSingleton().singletonTest();
		
		BillPughSingleton.getBillPughSingleton().SingletonTest();
		
	}

}
