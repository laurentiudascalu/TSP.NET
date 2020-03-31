using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace ObjectWCF
{
    public class ClassWCF: Interface
    {
        void Interface.AddEveniment(string nume)
        {
            Api api = new Api();
            api.AddEveniment(nume);
        }
        void Interface.AddLocatie(string nume)
        {
            Api api = new Api();
            api.AddLocatie(nume);
        }
        void Interface.AddPersoana(string nume)
        {
            Api api = new Api();
            api.AddPersoana(nume);
        }
        void Interface.AddPoza(string cale, string nume, string tip, string descriere)
        {
            Api api = new Api();
            api.AddPoza(cale, nume, tip, descriere);
        }
        void Interface.DelEveniment(int id)
        {
            Api api = new Api();
            api.DelEveniment(id);
        }
        void Interface.DelLocatie(int id)
        {
            Api api = new Api();
            api.DelLocatie(id);
        }
        void Interface.DelPersoana(int id)
        {
            Api api = new Api();
            api.DelPersoana(id);
        }
        void Interface.DelPoza(int id)
        {
            Api api = new Api();
            api.DelPoza(id);
        }
        List<Evenimente> Interface.GetEveniment(string nume)
        {
            Api api = new Api();
            return api.GetEveniment(nume);
        }
        List<Locatii> Interface.GetLocatie(string nume)
        {
            Api api = new Api();
            return api.GetLocatie(nume);
        }
        List<Persoane> Interface.GetPersoana(string nume)
        {
            Api api = new Api();
            return api.GetPersoana(nume);
        }
        List<Poze> Interface.GetPoza(string nume)
        {
            Api api = new Api();
            return api.GetPoza(nume);
        }
        void Interface.UpEveniment(int id, string nume)
        {
            Api api = new Api();
            api.UpEveniment(id, nume);
        }
        void Interface.UpLocatie(int id, string nume)
        {
            Api api = new Api();
            api.UpLocatie(id, nume);
        }
        void Interface.UpPersoana(int id, string nume)
        {
            Api api = new Api();
            api.UpPersoana(id, nume);
        }
        void Interface.UpPoza(int id, string cale, string nume, string tip, string descriere)
        {
            Api api = new Api();
            api.UpPoza(id, cale, nume, tip, descriere);
        }
    }
}
