using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGera.Pages
{
    class CadastroPage
    {
        public IWebDriver WebDriver { get; }
        public CadastroPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements
        public IWebElement txtNome => WebDriver.FindElement(By.Id("NomeCompleto"));
        public IWebElement txtCPF => WebDriver.FindElement(By.Id("Cpf"));
        public IWebElement txtDDDTel => WebDriver.FindElement(By.Id("Telefone1DDDPF"));
        public IWebElement txtNumTel => WebDriver.FindElement(By.Id("Telefone1PF"));
        public IWebElement txtDDDCel => WebDriver.FindElement(By.Id("Telefone2DDDPF"));
        public IWebElement txtNulCel => WebDriver.FindElement(By.Id("Telefone2PF"));
        public IWebElement txtDiaNasc => WebDriver.FindElement(By.Id("DataNascimentoDia"));
        public IWebElement txtMesNasc => WebDriver.FindElement(By.Id("DataNascimentoMes"));
        public IWebElement txtAnoNasc => WebDriver.FindElement(By.Id("DataNascimentoAno"));
        public IWebElement txtEmail => WebDriver.FindElement(By.Id("Email"));
        public IWebElement txtConfirmEmail => WebDriver.FindElement(By.Id("ConfirmarEmail"));
        public IWebElement txtSenha => WebDriver.FindElement(By.Id("Senha"));
        public IWebElement txtConfirmSenha => WebDriver.FindElement(By.Id("ConfirmarSenha"));
        public IWebElement rdbGeneroMasc => WebDriver.FindElement(By.XPath("//*[@id='Sexo' and @value='M']"));
        public IWebElement rdbGeneroFem => WebDriver.FindElement(By.XPath("//*[@id='Sexo' and @value='F']"));
        public IWebElement btConfirmar => WebDriver.FindElement(By.Id("btnClienteSalvarComCaptcha"));
        public IWebElement lblDadosPessoais => WebDriver.FindElement(By.XPath("//*[@id=1fsPessoaFisica1]/legend"));

        public void PreencherCamposPF(string nome, string cpf, string dddTel, string tel, string dddCel, string cel,
            string diaNasc, string mesNasc, string anoNasc, string email, string senha, string genero)
        {
            txtNome.SendKeys(nome);
            txtCPF.SendKeys(cpf);
            txtDDDTel.SendKeys(dddTel);
            txtNumTel.SendKeys(tel);
            txtDDDCel.SendKeys(dddCel);
            txtNulCel.SendKeys(cel);
            txtDiaNasc.SendKeys(diaNasc);
            txtMesNasc.SendKeys(mesNasc);
            txtAnoNasc.SendKeys(anoNasc);
            txtEmail.SendKeys(email);
            txtConfirmEmail.SendKeys(email);
            txtSenha.SendKeys(senha);
            txtConfirmSenha.SendKeys(senha);

            if (genero.Equals("F"))
                rdbGeneroFem.Click();
            else
                rdbGeneroMasc.Click();
        }
        public void ClicarConfirmar() => btConfirmar.Submit();
        public bool TelaCadastroFoiExibido() => lblDadosPessoais.Displayed;
    }
}
