package pageObjects;

import org.openqa.selenium.WebDriver;

public class SignIn_Action {
	
	public static void ExecuteIcatiLogin(WebDriver driver) throws Exception {
		
		// Option to  get values from Excel Sheet
		String sUserName = "phongnguyen";
		String sPassword = "";
		
		LoginPages.iCatiStageUser(driver).sendKeys(sUserName);
		LoginPages.iCatiStagePassword(driver).sendKeys(sPassword);
		LoginPages.iCatiStageSubmit(driver).click();
	
	}
	
	public static void OmniLogin(WebDriver driver) throws Exception {
		String sUserName = "pnguyen";
		String sPassword = "";
		
		LoginPages.omniUser(driver).sendKeys(sUserName);
		LoginPages.omniPassword(driver).sendKeys(sPassword);
		LoginPages.omniSubmit(driver).click();
	}
	
	public static void hhcahpsLogin(WebDriver driver) throws Exception {
		String sUserName = "pnguyen";
		String sPassword = "";
		
		LoginPages.hhcahpUser(driver).sendKeys(sUserName);
		LoginPages.hhcahpPassword(driver).sendKeys(sPassword);
		LoginPages.hhcahpsLogon(driver).click();
	}
		
	public static void olrLogin (WebDriver driver) throws Exception{
		String sUserName = "pnnguyen";
		String sPassword = "";
		
		LoginPages.olrUser(driver).sendKeys(sUserName);	
		LoginPages.olrPassword(driver).sendKeys(sPassword);
		LoginPages.olrLogon(driver).click();	
	}
	
	public static void sapphireLogin(WebDriver driver) throws Exception{
		String sUserName = "pnguyen";
		String sPassword = "";
		
		LoginPages.saphUser(driver).sendKeys(sUserName);
		LoginPages.saphPassword(driver).sendKeys(sPassword);
		LoginPages.saphSignIn(driver).click();
	}
}
