using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Esta é uma classe de testes do C#
//Para criar uma dessa, basta:
//1. Arquivo > Novo > Projeto > Projeto de Teste de Unidade (Visual C#) > [Nome da classe] > 'OK'
//Para executar a classe de testes, basta:
//1. Testar > Executar > Executar Todos os testes

namespace TakeTestExemple
{
	[TestClass]
	public class UnitTest1
	{
		//Criar uma variável do tipo WebDriver que guarda um objeto do Chrome 
		//Deve-se passar o endereço do driver do chrome que foi instalado no pc
		//neste caso está na pasta do projeto. É preciso colocar esse @ na frente - não sei porque rs
		IWebDriver driver = new ChromeDriver(@"C:\\Users\\beatr\\source\\repos\\TakeTestExemple");

		[TestMethod]
		public void TestMethod1()
		{
			
			//invoca a variável driver para passar a url do site que se quer abrir
			driver.Navigate().GoToUrl("http://10.0.0.152/dashboard/?wicket:bookmarkablePage=:kaffa.kis.view.LoginPage");
			//maximiza a janela aberta pelo código acima
			driver.Manage().Window.Maximize();

			Login();
			OpenDispatcher();
			Filter();

			//fecha tela
			//driver.Quit();
		}

		public void Login()
		{
			//indica a quem se refere cada variável buscando o campo html pelo nome
			var user = driver.FindElement(By.Name("username"));
			var pass = driver.FindElement(By.Name("password"));
			var btLogin = driver.FindElement(By.Name("submit"));

			//escreve nos campos
			user.SendKeys("beatriz");
			pass.SendKeys("bcpfl");
			btLogin.Click();
		}

		public void OpenDispatcher()
		{
			//guarda o resultado da busca pelo classname do objeto
			var btOpen = driver.FindElement(By.ClassName("dispatcher-btn"));

			//clica no botão encontrado
			btOpen.Click();
		}

		public void Filter()
		{
			
		}
	}
}
