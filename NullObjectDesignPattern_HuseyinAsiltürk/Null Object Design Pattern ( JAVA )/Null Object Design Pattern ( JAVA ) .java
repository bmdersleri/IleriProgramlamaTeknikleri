abstract class Emp
{
    protected String name;
    public abstract boolean isNull();
    public abstract String getName();
}
  
class Coder extends Emp
{
    public Coder(String name) 
    {
        this.name = name;
    }
    @Override
    public String getName() 
    {
        return name;
    }
    @Override
    public boolean isNull() 
    {
        return false;
    }
}
  
class NoClient extends Emp
{
    @Override
    public String getName() 
    {
        return "Not Available";
    }
  
    @Override
    public boolean isNull() 
    {
        return true;
    }
}
  
class EmpData 
{
      
    public static final String[] names = {"Hüseyin", "Merve"};
    public static Emp getClient(String name)
    {
        for (int i = 0; i < names.length; i++) 
        {
            if (names[i].equalsIgnoreCase(name))
            {
                return new Coder(name);
            }
        }
        return new NoClient();
    }
}
  
public class Main 
{
    public static void main(String[] args) 
    {
        Emp emp1 = EmpData.getClient("Hüseyin");
        Emp emp2 = EmpData.getClient("Merve");
        Emp emp3 = EmpData.getClient("Kübra"); 
  
  
        System.out.println(emp1.getName());
        System.out.println(emp2.getName());
        System.out.println(emp3.getName()); 
    }
}