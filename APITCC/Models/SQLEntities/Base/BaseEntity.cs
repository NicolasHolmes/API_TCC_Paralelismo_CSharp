using static APITCC.Models.SQLEntities.Base.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using APITCC.Models.SQLEntities.Interfaces;

namespace APITCC.Models.SQLEntities.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public BaseEntity()
        {
            DataCriacao = DateTime.Now;
            DataAtualizacao = DateTime.Now;
            Deletado = false;
        }
        [ReadOnly(true)]
        [Key]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool Deletado { get; set; }


    }
}
