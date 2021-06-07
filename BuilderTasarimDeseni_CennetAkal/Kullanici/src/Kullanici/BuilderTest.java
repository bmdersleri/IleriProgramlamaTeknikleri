package Kullanici;

public class BuilderTest {
    User user = new User.UserBuilder("Cennet", "Akal")
            .email("cennetakall@gmail.com").build();

}
