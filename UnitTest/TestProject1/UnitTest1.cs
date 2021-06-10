using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestProject1
{
    public interface ILog
    {
        void Write(string mensaje);
    }
    public class ConsoleLog:ILog         
    {
        public void Write(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
    public class BankAccount
    {
        public int Balance { get; set; }
        private readonly ILog log;
        public BankAccount(ILog _log)
        {
            this.log = _log;
        }

        public void Deposit(int deposit)
        {
            Balance += deposit;
        }
    }

    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Test1(4, 6);
        }

        [Test]
        public void Test1( )
        {
            //var resultado = a + b;
            //Assert.That(4+6,Is.EqualTo(7));  // Chequeo dado condiciones
            //Assert.Fail("Error en las pruebas"); // Lanzar el Fail
            //Assert.Inconclusive("Hola falta info"); // Lanzar dado prueba inconclusa una alerta en naranja
            //Assert.Warn("Prueba inconclusa"); // Lanza un mensaje de prueba similar al inconcluso


            

            Warn.If(2 + 2 != 5);
        }
    }
}