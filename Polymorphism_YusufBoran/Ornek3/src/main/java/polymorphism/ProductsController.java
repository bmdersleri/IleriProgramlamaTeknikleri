package polymorphism;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;

public class ProductsController {

	private ProductService productService;

	@Autowired
	public ProductsController(ProductService productService) {
		this.productService = productService;// new ProductManager();
	}

	public List<Product> getAll() {
		return this.productService.getAll();
	}

	public Product add(Product product) {
		return this.productService.add(product);
	}
}