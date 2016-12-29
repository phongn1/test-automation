package pageObjects;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

public class LoginPages {

	private static WebElement element = null;
	
	//Sapphire Login Page
	public static WebElement saphUser(WebDriver driver){
		element = driver.findElement(By.id("userNameInput"));
		return element;	
	}
	
	public static WebElement saphPassword(WebDriver driver){
		element = driver.findElement(By.id("passwordInput"));
		return element;
	}
	
	public static WebElement saphSignIn(WebDriver driver){
		element = driver.findElement(By.id("submitButton"));
		return element;
	}
	
	// HHCAHPS Login page
	public static WebElement hhcahpUser(WebDriver driver){
		element = driver.findElement(By.id("ctl00_PageContent_LogonName"));
		return element;
	}
	
	public static WebElement hhcahpPassword(WebDriver driver){
		element = driver.findElement(By.id("ctl00_PageContent_LogonPassword"));
		return element;
		
	}
	
	public static WebElement hhcahpsLogon(WebDriver driver){
		element = driver.findElement(By.id("ctl00_PageContent_Button1"));
		return element;
	}
	
	//ICati Stage user Login
	public static WebElement iCatiStageUser(WebDriver driver){
		element = driver.findElement(By.id("ctl00_content_main_frm_login_username"));
		return element;
	}
	
	public static WebElement iCatiStagePassword(WebDriver driver){
		element = driver.findElement(By.id("ctl00_content_main_frm_login_password"));
		return element;
	}
	
	public static WebElement iCatiStageSubmit(WebDriver driver){
		element = driver.findElement(By.id("ctl00_content_main_frm_login_submit"));
		return element;
	}

	// Omni Login
	public static WebElement omniUser(WebDriver driver){
		element = driver.findElement(By.id("ctl00_Content_Main_frm_login_username"));
		return element;
	}
	
	public static WebElement omniPassword(WebDriver driver){
		element = driver.findElement(By.id("ctl00_Content_Main_frm_login_password"));
		return element;
	}
	
	public static WebElement omniSubmit(WebDriver driver){
		element = driver.findElement(By.id("ctl00_Content_Main_frm_login_submit"));
		return element;
	}
	
	//OLR User Login
	public static WebElement olrUser(WebDriver driver){
		element = driver.findElement(By.id("usr"));
		return element;
	}
	
	public static WebElement olrPassword(WebDriver driver){
		element = driver.findElement(By.id("pwd"));
		return element;
	}
	
	public static WebElement olrLogon(WebDriver driver){
		element = driver.findElement(By.id("Submit2"));
		return element;
	}
	

}
