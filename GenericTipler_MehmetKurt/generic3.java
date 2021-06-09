package generic;

import java.util.ArrayList;
import java.util.List;

public class Main {

	public static void main(String[] args) {
			List a=new ArrayList();
			a.add("String bir atama");
			a.add(1542);
			System.out.println("\n Class Cast Exception Hatasý");
			for(int i=0;i<a.size();i++)
			{
				try
				{
					String value=(String) a.get(i);
					System.out.println("\n"+value+"\n");
				}
				catch(ClassCastException e)
				{
					System.out.println("Class Cast Exception Hata Kodu"+e.hashCode()+"\n");
				}
					
				
			}
			
		
		
		
		
		
	}
}
