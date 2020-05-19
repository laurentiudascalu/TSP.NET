using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WebApp.Models
{
    [DataContract(IsReference = true)]
    public partial class EvenimenteDTO
    {
        public EvenimenteDTO()
        {
            this.Del = 0;
            this.Pozes = new HashSet<PozeDTO>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nume { get; set; }
        [DataMember]
        public int Del { get; set; }
        [DataMember]
        public virtual ICollection<PozeDTO> Pozes { get; set; }
    }
}
