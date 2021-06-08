package polymorphism;

import java.util.List;

public interface ProductService {
	List<Product> getAll();

	Product add(Product product);
}