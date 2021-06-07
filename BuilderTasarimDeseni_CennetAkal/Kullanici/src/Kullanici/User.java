package Kullanici;

public class User {
	 private String adi; // required
	  private String soyadi; // required
	  private String email; // optional
	  private String gsmNo; // optional
	 
	  private User(UserBuilder builder) {
	    this.adi = builder.adi;
	    this.soyadi = builder.soyadi;
	    this.email = builder.email;
	    this.gsmNo = builder.gsmNo;
	  }
	 
	  public String getAdi() {
	    return adi;
	  }
	 
	  public String getSoyadi() {
	    return soyadi;
	  }
	 
	  public String getEmail() {
	    return email;
	  }
	 
	  public String getGsmNo() {
	    return gsmNo;
	  }
	 
	  public static class UserBuilder {
	    
	    private String adi;
	    private String soyadi;
	    private String email;
	    private String gsmNo;
	 
	    public UserBuilder(String adi, String soyadi) {
	      this.adi = adi;
	      this.soyadi = soyadi;
	    }
	 
	    public UserBuilder email(String email) {
	      this.email = email;
	      return this;
	    }
	 
	    public UserBuilder gsmNo(String gsmNo) {
	      this.gsmNo = gsmNo;
	      return this;
	    }
	 
	    public User build() {
	      return new User(this);
	    }
	 
	  }

}
