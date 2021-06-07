import Build.smallMenuBuilder;
import Build.OrderBuilder;
import Menu.Dessert;
import Menu.Drink;
import Menu.Food;
import Menu.Order;
import Menu.Salad;
public class Waiter {
	private OrderBuilder builder;

	   public Order makeOrder(Food food, Drink drink, Dessert dessert, Salad salad) {
	      if (food.getFood().equals("Hamburger") && drink.getDrink().equals("Cola") && dessert.getDesert().equals("Ice Cream") && salad.getSalad()
	                                                                                                                                   .equals("Cesar Salad")) {
	         builder = new smallMenuBuilder();
	      }

	      builder.setFood(food);
	      builder.setDrink(drink);
	      builder.setDessert(dessert);
	      builder.setSalad(salad);
	      return builder.getOrder();
	   }

	   public static void main(String[] args) {

	      Food food = new Food("Hamburger");
	      Drink drink = new Drink("Cola");
	      Dessert dessert = new Dessert("Ice Cream");
	      Salad salad = new Salad("Cesar Salad");

	      Waiter waiter = new Waiter();
	      Order smallMenu = waiter.makeOrder(food, drink, dessert, salad);

	      System.out.println("Food:" + smallMenu.getFood().getFood());
	      System.out.println("Drink:" + smallMenu.getDrink().getDrink());
	      System.out.println("Dessert:" + smallMenu.getDessert().getDesert());
	      System.out.println("Salad:" + smallMenu.getSalad().getSalad());
	   }

}
