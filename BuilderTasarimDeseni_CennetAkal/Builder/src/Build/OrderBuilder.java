package Build;

import Menu.Dessert;
import Menu.Drink;
import Menu.Food;
import Menu.Order;
import Menu.Salad;

public abstract class OrderBuilder {

	   private Order order;

	   public OrderBuilder() {

	   }

	   public Order getOrder() {
	      if (order == null) {
	         order = new Order();
	      }
	      return order;
	   }

	   public abstract void setFood(Food food);

	   public abstract void setDrink(Drink drink);

	   public abstract void setDessert(Dessert dessert);

	   public abstract void setSalad(Salad salad);
	}


