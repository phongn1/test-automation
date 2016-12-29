package pageObjects;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.support.ui.Select;


public class SapphireObjects {
	
	public static void openMcahpsReport(WebDriver driver) throws Exception {

		  //Click on Manage Profile
		  driver.findElement(By.linkText("Manage Profile")).click();  
		  // Select Company from Drop down list
		  driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
		  Select dropdown = new Select(driver.findElement(By.id("ctl00_PageContent_ctl00_DropDownListClientID")));
		 
		  dropdown.selectByVisibleText("UnitedHealthcare");
		  
		  driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);

		  // Click Change Selections
		  driver.findElement(By.id("Button_SelectProjectTypes")).click();
		  driver.manage().timeouts().implicitlyWait(20, TimeUnit.SECONDS);
		  
		  // Select All Project types
		  driver.findElement(By.id("ctl00_PageContent_ctl00_RadWindow_SelectProjectTypes_C_Button_ProjectTypeSelector_SelectAll")).click();
		  
		  // Click Save
		  driver.findElement(By.id("ctl00_PageContent_ctl00_RadWindow_SelectProjectTypes_C_Button_AcceptProjectTypeSelections")).click();;
		  
		  //Click on Reports Tab
		  driver.findElement(By.linkText("Reports")).click();
		  
		  // Click Check All 
		  driver.findElement(By.id("ctl00_PageContent_ctl00_ButtonReportsCheckAllNodes")).click();
		  
		  // Click Save Changes
		  driver.findElement(By.id("ctl00_PageContent_ctl00_ButtonSave")).click();
			 WebElement element = driver.findElement(By.linkText("Reporting"));
			  Actions action = new Actions(driver);
			  action.moveToElement(element).build().perform();	  
			  // Click Custom Reports
			  driver.findElement(By.linkText("Custom Reports")).click();
			  driver.manage().timeouts().implicitlyWait(20, TimeUnit.SECONDS);
			  //Click on MCAHPS - MAPD Expand
			  driver.findElement(By.xpath("/html/body/form/div[3]/div/div[5]/div/div/div[3]/ul/li[1]/a/span/span[1]")).click();
			  //Click on MAPD response summary Report
			  driver.findElement(By.xpath("/html/body/form/div[3]/div/div[5]/div/div/div[3]/ul/li[1]/div/ul/li[3]/a/span/span[2]")).click();
			  //Select Base Period if there are options.
			  Select dropdown2 = new Select(driver.findElement(By.id("ctl00_PageContent_TreeWrapper1_DropDownList_Periods")));
			  dropdown2.selectByVisibleText("2016");
			  
			  //Click Submit
			  driver.findElement(By.id("ctl00_PageContent_TreeWrapper1_Button_GetReport")).click();
	
		}
		

	public static void navigateAdminMenu(WebDriver driver) throws Exception{
		
		
	}
}
