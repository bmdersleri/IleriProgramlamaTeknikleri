package polymorphism;

import javax.persistence.Entity;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@Entity
@AllArgsConstructor
@NoArgsConstructor
public class Product {

	private int id;

	private int categoryId;

	private String productName;

	private double unitPrice;

	private short unitsInStock;

	private String quantityPerUnit;
}