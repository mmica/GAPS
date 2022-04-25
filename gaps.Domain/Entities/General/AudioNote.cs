using Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class AudioNote : FullAuditedAggregateRoot<Guid>
    {
        //No necesito definir un Id porque lo defino en las classes abstractas
       // public Guid Id { get; set; }
        public Guid User { get; set; }
        public Guid Customer { get; set; }
        public Byte Recorder { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }

        public AudioNote()
        {
        }
        public AudioNote(Guid id) : base(id)
        {
        }
       
    }
}
