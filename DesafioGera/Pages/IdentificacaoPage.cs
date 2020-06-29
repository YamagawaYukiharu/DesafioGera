using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGera.Pages
{
    class IdentificacaoPage
    {
        public IWebDriver WebDriver { get; }

        public IdentificacaoPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements
        public IWebElement txtEmail => WebDriver.FindElement(By.Id("Email"));
        public IWebElement rdbNaoPossuiCadastro => WebDriver.FindElement(By.Id("rbNaoCadastrado"));
        public IWebElement btContinuar => WebDriver.FindElement(By.Id("btnClienteCadastrar"));

        public void PreencherEmail(string email)
        {
            txtEmail.SendKeys(email);
        }


        public void SelecionarOpcaoPrimeiraCompra()
        {
            IJavaScriptExecutor js = WebDriver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].click();", rdbNaoPossuiCadastro);
            
        }

        public void ClicarContinuar()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnClienteCadastrar")));
            IJavaScriptExecutor js = WebDriver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].click();", btContinuar);
        }
       
    }
}
