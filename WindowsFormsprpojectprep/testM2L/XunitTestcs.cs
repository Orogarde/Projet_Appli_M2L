
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using WindowsFormsprpojectprep;

namespace testM2L
{
   public class XunitTestcs
    
    {
        [Fact]
        public void TestAdherent()
        {
             adhérent adherentTest = new adhérent("HANKS", "Jean"," Boulogne","66666"," 55555",15,new DateTime(1998, 12, 23),"14 rue du roi");
           
            Assert.Equal("Jean", adherentTest.prenom);
        }

        [Fact]
        public void TestFonctionGetclubliste()
        {
           
            Club clubTest1 = new Club("PFE", "PFE.com", "Issy", "06 66 66 66 66", "92130","pfe-contact@gmail.com", 1,"14 rue du roi");
            Club clubTest2 = new Club("ECS", "ECS.com", "Paris", "07 77 77 77 77", "75000","ecs-contact@gmail.com", 2, "12 rue des champs");
            Club clubTest3 = new Club("FED", "FED.com", "Clamart", "08 88 88 88 88", "92140","fed-contact@gmail.com", 3, "7 rue histoire");
            ClubManagement liste = new ClubManagement();
            liste.listClubs.Clear();
            liste.listClubs.Add(clubTest1);
            liste.listClubs.Add(clubTest2);
            liste.listClubs.Add(clubTest3);
            Club club = liste.GetClubliste(1);

            Assert.Equal("ECS", club.titre);
        }
        [Fact]
        public void TestFonctionGetadherentliste()
        {
            adhérent adherentTest1 = new adhérent("HANKS", "Jean", "Issy", "66", " 55", 13, new DateTime(1998, 12, 23), "15,Boulevard saint germain");
            adhérent adhérentTest2 = new adhérent("HANKS", "Jean", "Boulogne", "66666", " 55555", 15, new DateTime(2010, 11, 26), "6,rue de la tuile");
            AdherentManagement liste = new AdherentManagement();
            liste.listM.Clear();
            liste.listM.Add(adherentTest1);
            liste.listM.Add(adhérentTest2);
            adhérent adherent = liste.GetAdhérentliste(1);
            Assert.Equal("Boulogne", adherent.ville);
        }

        [Fact]
        public void TestFonctionGetEvenementtliste()
        {
            Evenement event1 = new Evenement(new DateTime(1999, 11, 26), new DateTime(2008, 12, 23), "EvenementTest");
            Evenement event2 = new Evenement(new DateTime(2010, 9, 11), new DateTime(2012, 10, 20), "EvenementTest2");
            Evenement event3 = new Evenement(new DateTime(2018, 5, 25), new DateTime(2021, 5, 12), "EvenementTest3");
            EvenementManagement liste = new EvenementManagement();
            liste.listEvenement.Clear();
            liste.listEvenement.Add(event1);
            liste.listEvenement.Add(event2);
            liste.listEvenement.Add(event3);
            Evenement EvenementTest =  liste.GetEvenementliste(2);
            Assert.Equal(new DateTime(2018, 5, 25),EvenementTest.debutEvenement );
        }

    }

}

