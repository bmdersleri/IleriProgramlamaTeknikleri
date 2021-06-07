package Build;

import Menu.Dessert;
import Menu.Drink;
import Menu.Food;
import Menu.Salad;

public class smallMenuBuilder extends OrderBuilder {
	@Override
	   public void setFood(Food food) {
	      getOrder().setFood(food);
	   }

	   @Override
	   public void setDrink(Drink drink) {
	      getOrder().setDrink(drink);
	      
	   }

	   @Override
	   public void setDessert(Dessert dessert) {
	      getOrder().setDessert(dessert);
	      
	   }

	   @Override
	   public void setSalad(Salad salad) {
	      getOrder().setSalad(salad);
	      
	   }

}
