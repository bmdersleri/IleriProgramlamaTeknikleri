package generic;

import java.util.ArrayList;
import java.util.List;

public class Main {

	public static void main(String[] args) {

                 List nonGenericList=new ArrayList();
		List <String> genericList=new ArrayList<>();
		nonGenericList.add("String bir deðer atayabiliyorum");
		nonGenericList.add(100+"istersem ýnteger"+15.5+"istersem double atama yapabilirim");
		genericList.add("Sadece string atama yapabilirim.");
		System.out.println(nonGenericList.get(0)+"\n"+nonGenericList.get(1));
		System.out.println(genericList.get(1)+"\n");
			
			
		
		
		
		
		
	}
}
