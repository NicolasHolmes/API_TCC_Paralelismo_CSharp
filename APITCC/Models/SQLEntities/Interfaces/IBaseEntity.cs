﻿using System.ComponentModel.DataAnnotations;
using System;

namespace APITCC.Models.SQLEntities.Interfaces
{
    public interface IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool Deletado { get; set; }

        public void BuildCreated()
        {
            DataCriacao = DateTime.Now;
            DataAtualizacao = null;
            Deletado = false;
        }
        public void BuildUpdated()
        {
            DataAtualizacao = DateTime.Now;
        }
        public void BuildDeleted()
        {
            Deletado = true;
        }
    }
}