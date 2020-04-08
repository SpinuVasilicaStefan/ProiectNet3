using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceFunctions
    {
        [OperationContract]
        void Verificare_existenta();
        [OperationContract]
        void Update_proprietati(string path, string coloana, string valoare);
        [OperationContract]
        void stergere_poza(string name);
        [OperationContract]
        void Tag(string path, string persoana);
        [OperationContract]
        void Add_Dinamic(string Nume);
        [OperationContract]
        List<string> Afisare_persoane();
        [OperationContract]
        List<string> Afisare_Media();
        [OperationContract]
        void Scriere_in_fisier(string path, string scris);
        [OperationContract]
        IList<string> Afisare_rezultate(string coloana, string date);
        [OperationContract]
        IList<string> Initializare_proprietati();
        [OperationContract]
        void Add_Media(string nume, string locatie, string path, string peisaj, string eveniment);
    }

    [ServiceContract]
    interface IFunctions : InterfaceFunctions
    {
    }

}
