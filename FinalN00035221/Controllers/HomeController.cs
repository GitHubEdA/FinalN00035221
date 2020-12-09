using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalN00035221.Models;

namespace FinalN00035221.Controllers
{
    public class HomeController : Controller
    {
        List<Jugador> jugadores = new List<Jugador>();
        List<Carta> mazo = new List<Carta>();
        Random random = new Random();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Jugar(List<string> Jugadores)
        {
            for (int i = 0; i < 5; i++)
            {
                var jugador = new Jugador();
                jugador.nombre = Jugadores[i];
                jugadores.Add(jugador);
            }
            repartirCartas(jugadores);

            return View(jugadores);
        }

        public void mazoCartas()
        {
            var carta1 = new Carta() { numero = 2, palo = 1 }; mazo.Add(carta1);
            var carta2 = new Carta() { numero = 3, palo = 1 }; mazo.Add(carta2);
            var carta3 = new Carta() { numero = 4, palo = 1 }; mazo.Add(carta3);
            var carta4 = new Carta() { numero = 5, palo = 1 }; mazo.Add(carta4);
            var carta5 = new Carta() { numero = 6, palo = 1 }; mazo.Add(carta5);
            var carta6 = new Carta() { numero = 7, palo = 1 }; mazo.Add(carta6);
            var carta7 = new Carta() { numero = 8, palo = 1 }; mazo.Add(carta7);
            var carta8 = new Carta() { numero = 9, palo = 1 }; mazo.Add(carta8);
            var carta9 = new Carta() { numero = 10, palo = 1 }; mazo.Add(carta9);
            var carta10 = new Carta() { numero = 11, palo = 1 }; mazo.Add(carta10);
            var carta11 = new Carta() { numero = 12, palo = 1 }; mazo.Add(carta11);
            var carta12 = new Carta() { numero = 13, palo = 1 }; mazo.Add(carta12);
            var carta13 = new Carta() { numero = 14, palo = 1 }; mazo.Add(carta13);
            var carta14 = new Carta() { numero = 2, palo = 2 }; mazo.Add(carta14);
            var carta15 = new Carta() { numero = 3, palo = 2 }; mazo.Add(carta15);
            var carta16 = new Carta() { numero = 4, palo = 2 }; mazo.Add(carta16);
            var carta17 = new Carta() { numero = 5, palo = 2 }; mazo.Add(carta17);
            var carta18 = new Carta() { numero = 6, palo = 2 }; mazo.Add(carta18);
            var carta19 = new Carta() { numero = 7, palo = 2 }; mazo.Add(carta19);
            var carta20 = new Carta() { numero = 8, palo = 2 }; mazo.Add(carta20);
            var carta21 = new Carta() { numero = 9, palo = 2 }; mazo.Add(carta21);
            var carta22 = new Carta() { numero = 10, palo = 2 }; mazo.Add(carta22);
            var carta23 = new Carta() { numero = 11, palo = 2 }; mazo.Add(carta23);
            var carta24 = new Carta() { numero = 12, palo = 2 }; mazo.Add(carta24);
            var carta25 = new Carta() { numero = 13, palo = 2 }; mazo.Add(carta25);
            var carta26 = new Carta() { numero = 14, palo = 2 }; mazo.Add(carta26);
            var carta27 = new Carta() { numero = 2, palo = 3 }; mazo.Add(carta27);
            var carta28 = new Carta() { numero = 3, palo = 3 }; mazo.Add(carta28);
            var carta29 = new Carta() { numero = 4, palo = 3 }; mazo.Add(carta29);
            var carta30 = new Carta() { numero = 5, palo = 3 }; mazo.Add(carta30);
            var carta31 = new Carta() { numero = 6, palo = 3 }; mazo.Add(carta31);
            var carta32 = new Carta() { numero = 7, palo = 3 }; mazo.Add(carta32);
            var carta33 = new Carta() { numero = 8, palo = 3 }; mazo.Add(carta33);
            var carta34 = new Carta() { numero = 9, palo = 3 }; mazo.Add(carta34);
            var carta35 = new Carta() { numero = 10, palo = 3 }; mazo.Add(carta35);
            var carta36 = new Carta() { numero = 11, palo = 3 }; mazo.Add(carta36);
            var carta37 = new Carta() { numero = 12, palo = 3 }; mazo.Add(carta37);
            var carta38 = new Carta() { numero = 13, palo = 3 }; mazo.Add(carta38);
            var carta39 = new Carta() { numero = 14, palo = 3 }; mazo.Add(carta39);
            var carta40 = new Carta() { numero = 2, palo = 4 }; mazo.Add(carta40);
            var carta41 = new Carta() { numero = 3, palo = 4 }; mazo.Add(carta41);
            var carta42 = new Carta() { numero = 4, palo = 4 }; mazo.Add(carta42);
            var carta43 = new Carta() { numero = 5, palo = 4 }; mazo.Add(carta43);
            var carta44 = new Carta() { numero = 6, palo = 4 }; mazo.Add(carta44);
            var carta45 = new Carta() { numero = 7, palo = 4 }; mazo.Add(carta45);
            var carta46 = new Carta() { numero = 8, palo = 4 }; mazo.Add(carta46);
            var carta47 = new Carta() { numero = 9, palo = 4 }; mazo.Add(carta47);
            var carta48 = new Carta() { numero = 10, palo = 4 }; mazo.Add(carta48);
            var carta49 = new Carta() { numero = 11, palo = 4 }; mazo.Add(carta49);
            var carta50 = new Carta() { numero = 12, palo = 4 }; mazo.Add(carta50);
            var carta51 = new Carta() { numero = 13, palo = 4 }; mazo.Add(carta51);
            var carta52 = new Carta() { numero = 14, palo = 4 }; mazo.Add(carta52);
        }

        public void repartirCartas(List<Jugador> jugadores)
        {
            mazoCartas();

            for (int i = 0; i < 5; i++)
            {
                jugadores[i].mano = generarMano();
            }
        }

        public List<Carta> generarMano()
        {
            List<Carta> mano = new List<Carta>();
            int i = 0;
            while (i < 5)
            {
                int index = random.Next(mazo.Count);
                mano.Add(mazo[index]);
                mano = mano.OrderBy(o => o.numero).ToList();
                mazo.RemoveAt(index);
                i++;
            }
            return mano;
        }

        public string EscaleraColor(List<Carta> cartas)
        {
            Carta falsa = new Carta();
            int i = 0;

            foreach (var carta in cartas)
            {
                if (falsa.numero + 1 == carta.numero && falsa.palo == carta.palo)
                {
                    falsa = carta; i++;
                }
                if (i == 0)
                {
                    falsa = carta; i++;
                }
            }
            if (i == 5)
            {
                return "Escalera de color";
            }
            else
            {
                return "Otra";
            }
        }
        public string Poker(List<Carta> cartas)
        {
            Carta falsa = new Carta();
            int i = 0;
            foreach (var carta in cartas)
            {
                if (falsa.numero == carta.numero && i < 4)
                {
                    falsa = carta; i++;
                }
                else
                {
                    falsa = carta; i = 1;
                }
            }
            if (i == 4)
            {
                return "Poker";
            }
            else
            {
                return "No Poker";
            }
        }
        public string Color(List<Carta> cartas)
        {
            Carta falsa = new Carta();
            int i = 0;
            foreach (var carta in cartas)
            {
                if (falsa.palo == carta.palo)
                {
                    falsa = carta; i++;
                }
                if (i == 0)
                {
                    falsa = carta; i++;
                }
            }
            if (i == 5)
            {
                return "Color";
            }
            else
            {
                return "No Color";
            }
        }
        public string Escalera(List<Carta> cartas)
        {
            Carta falsa = new Carta();
            int i = 0;

            foreach (var carta in cartas)
            {
                if (falsa.numero + 1 == carta.numero)
                {
                    falsa = carta; i++;
                }
                if (i == 0)
                {
                    falsa = carta; i++;
                }
            }
            if (i == 5)
            {
                return "Escalera";
            }
            else
            {
                return "No Escalera";
            }
        }
        public string Full(List<Carta> cartas)
        {
            Carta trio = new Carta();
            int segundo = 0;
            int i = 0;
            int j = 0;

            foreach (var carta in cartas)
            {
                if (trio.numero == carta.numero)
                {
                    trio = carta;
                    if (segundo == 0)
                    {
                        i++;
                    }
                    else if (segundo == 1)
                    {
                        j++;
                    }
                }
                if (i == 0)
                {
                    trio = carta; i++; j++;
                }
                if (trio.numero != carta.numero)
                {
                    segundo = 1;
                    trio = carta;
                }
            }
            if ((i == 2 && j == 3) || (i == 3 && j == 2))
            {
                return "Full";
            }
            else
            {
                return "No Full";
            }
        }
        public string Trio(List<Carta> cartas)
        {
            Carta trio = new Carta();

            int i = 0;
            int j = 0;

            foreach (var carta in cartas)
            {
                if (trio.numero == carta.numero)
                {
                    trio = carta;
                    if (i < 3)
                    {
                        i++;
                    }
                    else if (i >= 3)
                    {
                        j++;
                    }
                }
                if (i == 0)
                {
                    trio = carta; i++; j++;
                }
                if (i == 3)
                {
                    trio = carta;
                }
                if (trio.numero != carta.numero)
                {
                    trio = carta;
                    i = 1;
                }

            }
            if (i == 3 && j == 1)
            {
                return "Trio";
            }
            else
            {
                return "No Trio";
            }
        }
        public string UnPar(List<Carta> cartas)
        {
            Carta par = new Carta();
            int segundo = 0;
            int i = 0;
            int j = 0;

            foreach (var carta in cartas)
            {
                if (par.numero == carta.numero)
                {
                    par = carta;
                    if (segundo == 0)
                    {
                        i++;
                    }
                    else if (segundo == 1)
                    {
                        j++;
                    }
                }
                if (i == 0)
                {
                    par = carta; i++; j++;
                }
                if (par.numero != carta.numero)
                {
                    segundo = 1;
                    par = carta;
                }
            }
            if ((i == 2 && j == 1)||(i == 1 && j == 2))
            {
                return "Un Par";
            }
            else
            {
                return "No Par";
            }
        }
        public string DoblePar(List<Carta> cartas)
        {
            Carta par = new Carta();
            int segundo = 0;
            int i = 0;
            int j = 0;

            foreach (var carta in cartas)
            {
                if (par.numero == carta.numero)
                {
                    par = carta;
                    if (segundo == 0)
                    {
                        i++;
                    }
                    else if (segundo == 1)
                    {
                        j++;
                    }
                }
                if (i == 0)
                {
                    par = carta; i++; j++;
                }
                if (par.numero != carta.numero)
                {
                    segundo = 1;
                    par = carta;
                }
            }
            if (i == 2 && j == 2)
            {
                return "Un Doble";
            }
            else
            {
                return "No Doble";
            }
        }
    }
}
