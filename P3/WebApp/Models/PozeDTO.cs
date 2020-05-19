using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WebApp.Models
{
    [DataContract(IsReference = true)]
    public partial class PozeDTO
    {
        public PozeDTO()
        {
            this.Del = 0;
            this.Persoanes = new HashSet<PersoaneDTO>();
            this.Evenimentes = new HashSet<EvenimenteDTO>();
            this.Locatiis = new HashSet<LocatiiDTO>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Cale { get; set; }
        [DataMember]
        public string Nume { get; set; }
        [DataMember]
        public string Tip { get; set; }
        [DataMember]
        public System.DateTime Data_creare { get; set; }
        [DataMember]
        public string Descriere { get; set; }
        [DataMember]
        public int Del { get; set; }
        [DataMember]
        public virtual ICollection<PersoaneDTO> Persoanes { get; set; }
        [DataMember]
        public virtual ICollection<EvenimenteDTO> Evenimentes { get; set; }
        [DataMember]
        public virtual ICollection<LocatiiDTO> Locatiis { get; set; }
    }
}
