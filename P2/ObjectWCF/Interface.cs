using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface Interface
    {
        [OperationContract]
        void AddEveniment(string nume);

        [OperationContract]
        void AddLocatie(string nume);

        [OperationContract]
        void AddPersoana(string nume);

        [OperationContract]
        void AddPoza(string cale, string nume, string tip, string descriere);

        [OperationContract]
        void DelEveniment(int id);

        [OperationContract]
        void DelLocatie(int id);

        [OperationContract]
        void DelPersoana(int id);

        [OperationContract]
        void DelPoza(int id);

        [OperationContract]
        List<Evenimente> GetEveniment(string nume);

        [OperationContract]
        List<Locatii> GetLocatie(string nume);

        [OperationContract]
        List<Persoane> GetPersoana(string nume);

        [OperationContract]
        List<Poze> GetPoza(string nume);

        [OperationContract]
        void UpEveniment(int id, string nume);

        [OperationContract]
        void UpLocatie(int id, string nume);

        [OperationContract]
        void UpPersoana(int id, string nume);

        [OperationContract]
        void UpPoza(int id, string cale, string nume, string tip, string descriere);
    }
}
