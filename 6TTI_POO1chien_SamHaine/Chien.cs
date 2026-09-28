using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_POO1chien_SamHaine
{
    internal class Chien
    {
        private string _nom;
        private string _race;
        private string _carnetSante = "";
        private int _age;
        public Chien(string nom,int age, string race)
        {
            _nom = nom;
            _race = race;
            _age = age;
        }
        public string AfficheCaracteristiques()
        {
            return "Nom : " + _nom + " - Age : " + _age + " - Race : " + _race;
        }
        public void Vacciner(string nomVaccin)
        {
            _carnetSante += nomVaccin + " ";
        }
        public string infoChien()
        {
            return "Mon chien s'appelle " + _nom + ", il est de race " + _race + " et son carnet de santé contient : " + _carnetSante;
        }
    }
}