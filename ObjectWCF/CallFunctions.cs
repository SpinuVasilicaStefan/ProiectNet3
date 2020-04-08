using Proiect.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    public class CallFunctions : IFunctions
    {
        void InterfaceFunctions.Verificare_existenta()
        {
            
        }
        void InterfaceFunctions.Update_proprietati(string path, string coloana, string valoare)
        {
            Functii.Update_proprietati(path, coloana, valoare);
        }

        void InterfaceFunctions.stergere_poza(string name)
        {
            Functii.stergere_poza(name);
        }

        void InterfaceFunctions.Tag(string path, string persoana)
        {
            Functii.Tag(path, persoana);
        }

        void InterfaceFunctions.Add_Dinamic(string Nume)
        {
            Functii.Add_Dinamic(Nume);
        }

        List<string> InterfaceFunctions.Afisare_persoane()
        {
            return Functii.Afisare_persoane();
        }

        List<string> InterfaceFunctions.Afisare_Media()
        {
            return Functii.Afisare_Media();
        }

        void InterfaceFunctions.Scriere_in_fisier(string path, string scris)
        {
            Functii.Scriere_in_fisier(path, scris);
        }

        IList<string> InterfaceFunctions.Afisare_rezultate(string coloana, string date)
        {
            return Functii.Afisare_rezultate(coloana, date);
        }

        void InterfaceFunctions.Add_Media(string nume, string locatie, string path, string peisaj, string eveniment)
        {
            Functii.Add_Media(nume, locatie, path, peisaj, eveniment);
        }

        IList<string> InterfaceFunctions.Initializare_proprietati()
        {
            return Functii.Initializare_proprietati();
        }
    }
}
