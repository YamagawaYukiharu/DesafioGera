using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGera.Pages
{
    class CarrinhoPage
    {
        public IWebDriver WebDriver { get; }
        public CarrinhoPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements
        public IWebElement lblMeuCarrinho => WebDriver.FindElement(By.XPath("//*[@id='sectionContent']/h2"));

        public bool CadastroFoiRealizado() => lblMeuCarrinho.Displayed;
    }
}
