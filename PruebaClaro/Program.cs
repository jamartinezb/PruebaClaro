using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PruebaClaro
{
    class Program
    {
        static void Main(string[] args)
        {
            string usu = "admin";
            string pass = "admin";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://dineshvelhal.github.io/testautomation-playground/login.html";
            var nav = driver.Navigate();

            //login en la pagina web
            IWebElement userName = driver.FindElement(By.Id("user"));
            userName.SendKeys(usu);
            IWebElement userPass = driver.FindElement(By.Id("password"));
            userPass.SendKeys(pass);
            IWebElement loginButt = driver.FindElement(By.Id("login"));
            loginButt.Click();

            //seleccion de la pizza
            System.Threading.Thread.Sleep(1500);
            IWebElement pizzSize = driver.FindElement(By.Id("rad_small"));
            pizzSize.Click();

            IWebElement pizzFlavOpti = driver.FindElement(By.Id("select_flavor"));
            SelectElement select = new SelectElement(pizzFlavOpti);
            select.SelectByText("Supreme");

            IWebElement pizzSauce = driver.FindElement(By.Id("rad_barbeque"));
            pizzSauce.Click();

            //tomoto
            IWebElement pizzTopp = driver.FindElement(By.Id("tomoto"));
            pizzTopp.Click();

            
            IWebElement quantity = driver.FindElement(By.Id("quantity"));
            quantity.SendKeys("2");

            
            IWebElement addPaizza = driver.FindElement(By.Id("submit_button"));
            addPaizza.Click();
            nav.Refresh();

            //seleccion 2

            System.Threading.Thread.Sleep(2000);
            //seleccion de la pizza
            System.Threading.Thread.Sleep(1500);
            IWebElement pizzSizeM = driver.FindElement(By.Id("rad_medium"));
            pizzSizeM.Click();

            IWebElement pizzFlavOptiP = driver.FindElement(By.Id("select_flavor"));
            SelectElement selectP = new SelectElement(pizzFlavOptiP);
            selectP.SelectByText("Pepperoni");

            IWebElement pizzSauceB = driver.FindElement(By.Id("rad_barbeque"));
            pizzSauceB.Click();

            //tomoto
            IWebElement pizzTopp2 = driver.FindElement(By.Id("tomoto"));
            pizzTopp2.Click();


            IWebElement quantity2 = driver.FindElement(By.Id("quantity"));
            quantity2.SendKeys("-21");


            IWebElement addPaizza2 = driver.FindElement(By.Id("submit_button"));
            addPaizza2.Click();

            //segundo punto
            //segundo punto
            //segundo punto

            driver.Url = "https://dineshvelhal.github.io/testautomation-playground/advanced.html";


            IWebElement rating = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/table/tbody/tr/td[2]/label"));
            string result = rating.GetAttribute("content");
            Console.WriteLine("el valor es:"+result);

            IWebElement resultado = driver.FindElement(By.Id("txt_rating"));
            resultado.SendKeys(result);

            IWebElement check = driver.FindElement(By.Id("check_rating"));
            check.Click();
            

        }
    }
}
