using FinalN00035221.Controllers;
using FinalN00035221.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestFinal
{
    public class Tests
    {
        [Test]
        public void EscaleraReal()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 10, palo = 1 });
            cartas.Add(new Carta() { numero = 11, palo = 1 });
            cartas.Add(new Carta() { numero = 12, palo = 1 });
            cartas.Add(new Carta() { numero = 13, palo = 1 });
            cartas.Add(new Carta() { numero = 14, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.EscaleraColor(cartas);

            Assert.AreEqual("Escalera de color", resultado);
        }

        [Test]
        public void EscaleraDeColor()
        {
            List<Carta> cartas = new List<Carta>();
            
            cartas.Add(new Carta() { numero = 5, palo = 1 });
            cartas.Add(new Carta() { numero = 6, palo = 1 });
            cartas.Add(new Carta() { numero = 7, palo = 1 });
            cartas.Add(new Carta() { numero = 8, palo = 1 });
            cartas.Add(new Carta() { numero = 9, palo = 1 });

            var controller = new HomeController();

            var resultado = controller.EscaleraColor(cartas);

            Assert.AreEqual("Escalera de color", resultado);
        }

        [Test]
        public void NoEscaleraDeColor()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 5, palo = 1 });
            cartas.Add(new Carta() { numero = 6, palo = 1 });
            cartas.Add(new Carta() { numero = 8, palo = 1 });
            cartas.Add(new Carta() { numero = 8, palo = 1 });
            cartas.Add(new Carta() { numero = 9, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.EscaleraColor(cartas);

            Assert.AreEqual("Otra", resultado);
        }

        [Test]
        public void NoEscaleraDeColorDistintosPalos()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 5, palo = 1 });
            cartas.Add(new Carta() { numero = 6, palo = 2 });
            cartas.Add(new Carta() { numero = 7, palo = 1 });
            cartas.Add(new Carta() { numero = 8, palo = 3 });
            cartas.Add(new Carta() { numero = 9, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.EscaleraColor(cartas);

            Assert.AreEqual("Otra", resultado);
        }

        [Test]
        public void ManoDePoker()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 7, palo = 1 });
            cartas.Add(new Carta() { numero = 14, palo = 1 });
            cartas.Add(new Carta() { numero = 14, palo = 2 });
            cartas.Add(new Carta() { numero = 14, palo = 3 });
            cartas.Add(new Carta() { numero = 14, palo = 4 });
 
            var controller = new HomeController();
            var resultado = controller.Poker(cartas);

            Assert.AreEqual("Poker", resultado);
        }

        [Test]
        public void NoManoDePoker()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 2, palo = 1 });
            cartas.Add(new Carta() { numero = 2, palo = 2 });
            cartas.Add(new Carta() { numero = 2, palo = 3 });
            cartas.Add(new Carta() { numero = 10, palo = 1 });
            cartas.Add(new Carta() { numero = 10, palo = 4 });

            var controller = new HomeController();
            var resultado = controller.Poker(cartas);

            Assert.AreEqual("No Poker", resultado);
        }

        [Test]
        public void Color()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 4, palo = 1 });
            cartas.Add(new Carta() { numero = 7, palo = 1 });
            cartas.Add(new Carta() { numero = 9, palo = 1 });
            cartas.Add(new Carta() { numero = 10, palo = 1 });
            cartas.Add(new Carta() { numero = 12, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Color(cartas);

            Assert.AreEqual("Color", resultado);
        }

        [Test]
        public void NoColor()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 2, palo = 1 });
            cartas.Add(new Carta() { numero = 3, palo = 2 });
            cartas.Add(new Carta() { numero = 4, palo = 3 });
            cartas.Add(new Carta() { numero = 5, palo = 4 });
            cartas.Add(new Carta() { numero = 6, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Color(cartas);

            Assert.AreEqual("No Color", resultado);
        }
        [Test]
        public void Escalera()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 2, palo = 1 });
            cartas.Add(new Carta() { numero = 3, palo = 3 });
            cartas.Add(new Carta() { numero = 4, palo = 2 });
            cartas.Add(new Carta() { numero = 5, palo = 4 });
            cartas.Add(new Carta() { numero = 6, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Escalera(cartas);

            Assert.AreEqual("Escalera", resultado);
        }
        [Test]
        public void EscaleraMismoPalo()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 2, palo = 1 });
            cartas.Add(new Carta() { numero = 3, palo = 1 });
            cartas.Add(new Carta() { numero = 4, palo = 1 });
            cartas.Add(new Carta() { numero = 5, palo = 1 });
            cartas.Add(new Carta() { numero = 6, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Escalera(cartas);

            Assert.AreEqual("Escalera", resultado);
        }
        [Test]
        public void NoEscalera()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 7, palo = 1 });
            cartas.Add(new Carta() { numero = 3, palo = 3 });
            cartas.Add(new Carta() { numero = 4, palo = 2 });
            cartas.Add(new Carta() { numero = 4, palo = 4 });
            cartas.Add(new Carta() { numero = 5, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Escalera(cartas);

            Assert.AreEqual("No Escalera", resultado);
        }
        [Test]
        public void Full()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 10, palo = 1 });
            cartas.Add(new Carta() { numero = 10, palo = 3 });
            cartas.Add(new Carta() { numero = 13, palo = 2 });
            cartas.Add(new Carta() { numero = 13, palo = 4 });
            cartas.Add(new Carta() { numero = 13, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Full(cartas);

            Assert.AreEqual("Full", resultado);
        }

        [Test]
        public void NoFull()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 9, palo = 1 });
            cartas.Add(new Carta() { numero = 10, palo = 3 });
            cartas.Add(new Carta() { numero = 13, palo = 2 });
            cartas.Add(new Carta() { numero = 13, palo = 4 });
            cartas.Add(new Carta() { numero = 13, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Full(cartas);

            Assert.AreEqual("No Full", resultado);
        }
        [Test]
        public void FullDistintoMaso()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 10, palo = 1 });
            cartas.Add(new Carta() { numero = 10, palo = 3 });
            cartas.Add(new Carta() { numero = 10, palo = 2 });
            cartas.Add(new Carta() { numero = 13, palo = 4 });
            cartas.Add(new Carta() { numero = 13, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Full(cartas);

            Assert.AreEqual("Full", resultado);
        }
        [Test]
        public void Trio()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 4, palo = 1 });
            cartas.Add(new Carta() { numero = 7, palo = 3 });
            cartas.Add(new Carta() { numero = 13, palo = 2 });
            cartas.Add(new Carta() { numero = 13, palo = 4 });
            cartas.Add(new Carta() { numero = 13, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Trio(cartas);

            Assert.AreEqual("Trio", resultado);
        }
        [Test]
        public void TrioDesdeAbajo()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 4, palo = 1 });
            cartas.Add(new Carta() { numero = 4, palo = 3 });
            cartas.Add(new Carta() { numero = 4, palo = 2 });
            cartas.Add(new Carta() { numero = 7, palo = 4 });
            cartas.Add(new Carta() { numero = 13, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Trio(cartas);

            Assert.AreEqual("Trio", resultado);
        }
        [Test]
        public void NoTrio()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 4, palo = 1 });
            cartas.Add(new Carta() { numero = 4, palo = 3 });
            cartas.Add(new Carta() { numero = 6, palo = 2 });
            cartas.Add(new Carta() { numero = 13, palo = 4 });
            cartas.Add(new Carta() { numero = 13, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.Trio(cartas);

            Assert.AreEqual("No Trio", resultado);
        }
        [Test]
        public void Par()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 2, palo = 1 });
            cartas.Add(new Carta() { numero = 6, palo = 3 });
            cartas.Add(new Carta() { numero = 8, palo = 2 });
            cartas.Add(new Carta() { numero = 14, palo = 4 });
            cartas.Add(new Carta() { numero = 14, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.UnPar(cartas);

            Assert.AreEqual("Un Par", resultado);
        }
        [Test]
        public void ParDesdeAbajo()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 2, palo = 1 });
            cartas.Add(new Carta() { numero = 2, palo = 3 });
            cartas.Add(new Carta() { numero = 6, palo = 2 });
            cartas.Add(new Carta() { numero = 8, palo = 4 });
            cartas.Add(new Carta() { numero = 14, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.UnPar(cartas);

            Assert.AreEqual("Un Par", resultado);
        }
        [Test]
        public void NoPar()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 3, palo = 1 });
            cartas.Add(new Carta() { numero = 6, palo = 3 });
            cartas.Add(new Carta() { numero = 6, palo = 2 });
            cartas.Add(new Carta() { numero = 8, palo = 4 });
            cartas.Add(new Carta() { numero = 8, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.UnPar(cartas);

            Assert.AreEqual("No Par", resultado);
        }
        [Test]
        public void DoblePar()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 6, palo = 3 });
            cartas.Add(new Carta() { numero = 6, palo = 2 });
            cartas.Add(new Carta() { numero = 8, palo = 4 });
            cartas.Add(new Carta() { numero = 8, palo = 1 });
            cartas.Add(new Carta() { numero = 10, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.DoblePar(cartas);

            Assert.AreEqual("Un Doble", resultado);
        }

        [Test]
        public void NoDoble()
        {
            List<Carta> cartas = new List<Carta>();

            cartas.Add(new Carta() { numero = 2, palo = 1 });
            cartas.Add(new Carta() { numero = 6, palo = 3 });
            cartas.Add(new Carta() { numero = 8, palo = 2 });
            cartas.Add(new Carta() { numero = 14, palo = 4 });
            cartas.Add(new Carta() { numero = 14, palo = 1 });

            var controller = new HomeController();
            var resultado = controller.DoblePar(cartas);

            Assert.AreEqual("No Doble", resultado);
        }
    }
}