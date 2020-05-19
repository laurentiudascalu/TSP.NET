using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePoze;
namespace WebApp.Pages.Poze
{
    public class IndexModel : PageModel
    {
        InterfaceClient pcc = new InterfaceClient();
        public List<PozeDTO> Pozes { get; set; }

        public IndexModel()
        {
            Pozes = new List<PozeDTO>();
        }
        public async Task OnGetAsync()
        {
            var poze = await pcc.GetPozaAsync("");
            foreach (var item in poze)
            {
                // Trebuia folosit AutoMapper. Transform Post in PostDTO
                PozeDTO pd = new PozeDTO();
                pd.Id = item.Id;
                pd.Cale = item.Cale;
                pd.Nume = item.Nume;
                pd.Tip = item.Tip;
                pd.Data_creare = item.Data_creare;
                pd.Descriere = item.Descriere;
                pd.Del = item.Del;
                foreach (var cc in item.Persoanes)
                {
                    PersoaneDTO cdto = new PersoaneDTO();
                    cdto.Id = cc.Id;
                    cdto.Nume = cc.Nume;
                    cdto.Del = cc.Del;
                    pd.Persoanes.Add(cdto);
                }
                foreach (var cc in item.Locatiis)
                {
                    LocatiiDTO cdto = new LocatiiDTO();
                    cdto.Id = cc.Id;
                    cdto.Nume = cc.Nume;
                    cdto.Del = cc.Del;
                    pd.Locatiis.Add(cdto);
                }
                foreach (var cc in item.Evenimentes)
                {
                    EvenimenteDTO cdto = new EvenimenteDTO();
                    cdto.Id = cc.Id;
                    cdto.Nume = cc.Nume;
                    cdto.Del = cc.Del;
                    pd.Evenimentes.Add(cdto);
                }
                Pozes.Add(pd);
            }
        }
    }
}
