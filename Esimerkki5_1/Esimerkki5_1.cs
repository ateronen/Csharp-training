using System;
using System.Collections.Generic;
using System.Text;

namespace Esimerkki5_1
{
    //Tässä määritellään Asunto-luokka.
    class Asunto
    {

        /* 
          * Seuraavassa määritellään attribuutit. Huomaa, että niiden 
          * saantimääreet ovat public. Tämä tarkoittaa sitä, että 
          * ne ovat myös näkyvissä niiden oman luokkansa (Asunto) ulkopuolella. 
         */
        public decimal pinta_ala;
        public int huone_maara;
        public decimal vuokra;
        public bool vapaa;

        
        //Tässä määritellään tulostaTiedot()-metodi, joka tulostaa asunnon tiedot näytölle.
        public void TulostaTiedot()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\tAsunnon tiedot");
            Console.WriteLine("\t--------------");
            Console.WriteLine("\tPinta-ala={0, 0:f2}", pinta_ala);
            Console.WriteLine("\tHuoneiden lukumäärä=" + huone_maara);
            Console.WriteLine("\tVuokra={0}€", vuokra);
        }
        /*
         * Seuraavassa määritellään naytaTila()-metodi, joka tarkistaa
         * vapaa-attribuutin arvoa ja sen perusteella tulostaa eri viestejä
         * näytölle. Huomaa, sarkain (\t) tulostuksessa.
         */

        public void NaytaTila()
        {
            bool vapaa;
            if (vapaa = true)

                Console.WriteLine("\tAsunto on vapaa.");
            else
                Console.WriteLine("\tAsunto on varattu.");

        }
    }



    //Tämä on pääohjelman luokka, johon kuuluu Main()-metodi, josta ohjelma aloitetaan.
    class Esimerkki5_1
    {
        static void Main()
        {

            //Tässä ilmoitetaan, että aiotaan luoda asunto-niminen olio Asunto-luokasta
            Asunto asunto;

            //Tässä varataan tietokoneen muistista tila asunto-oliolle 
            //ja se luodaan lopullisesti.  
            asunto = new Asunto
            {
                //Tässä olion attribuutit alustetaan.
                pinta_ala = 62.45m,
                huone_maara = 3,
                vuokra = 643.00m,
                vapaa = false
            };

            //Tässä kutsutaan asunto-olion TulostaTiedot()-metodi, joka tulostaa sen tiedot.
            asunto.TulostaTiedot();


            /*
             * Tässä kutsutaan asunto-olion NaytaTila()-metodi, joka ilmoittaa,
             * onko asunto vapaa vai varattu.
             */
            asunto.NaytaTila();


            Console.Read();

        }
    }
}