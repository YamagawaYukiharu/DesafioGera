using DesafioGera.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DesafioGera.Steps
{
    [Binding]
    class CadastroSteps
    {
        IWebDriver webDriver;
        IdentificacaoPage idPage;
        CadastroPage cadPage;
        CarrinhoPage carPage;

        [Given(@"que acesso o site de compras")]
        public void DadoQueAcessoOSiteDeCompras()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Navigate().GoToUrl("https://carrinho.extra.com.br/Checkout?ReturnUrl=//www.extra.com.br#login");
            idPage = new IdentificacaoPage(webDriver);
            cadPage = new CadastroPage(webDriver);
            carPage = new CarrinhoPage(webDriver);
        }

        [Given(@"que preencho o e-mail")]
        public void DadoQuePreenchoOE_Mail(Table table)
        {
            dynamic valores = table.CreateDynamicInstance();

            idPage.PreencherEmail(valores.Email);
        }

        [Given(@"informo que essa é minha primeira compra")]
        public void DadoInformoQueEssaEMinhaPrimeiraCompra()
        {
            idPage.SelecionarOpcaoPrimeiraCompra();
        }

        [When(@"clico em continuar")]
        public void QuandoClicoEmContinuar()
        {
            idPage.ClicarContinuar();
        }

        [Then(@"vejo a tela de cadastro")]
        public void EntaoVejoATelaDeCadastro()
        {
            Assert.That(cadPage.TelaCadastroFoiExibido, Is.True);
        }

        [When(@"preencho os campos obrigatório e salvar")]
        public void QuandoPreenchoOsCamposObrigatorioESalvar(Table table)
        {
            dynamic valores = table.CreateDynamicInstance();

            cadPage.PreencherCamposPF(valores.Nome, valores.CPF, valores.DDDTelefone,
                valores.Telefone, valores.DDDCelular, valores.Celular, valores.DiaNasc,
                valores.MesNasc, valores.AnoNasc, valores.Email, valores.Senha, valores.Genero);
            cadPage.ClicarConfirmar();
        }

        [Then(@"vejo o meu carrinho de compras")]
        public void EntaoVejoOMeuCarrinhoDeCompras()
        {
            Assert.That(carPage.CadastroFoiRealizado, Is.True);
        }
    }
}
