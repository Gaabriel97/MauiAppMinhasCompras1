﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiAppMinhasCompras1.Models
{
    public class Produto
    {
        string _descricao;
        string _categoria;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao
        {
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a Descrição");
                }

                _descricao = value;
            }
        }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
        public double Total { get => Quantidade * Preco; }
        public string Categoria
        {
            get => _categoria;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a Categoria");
                }

                _categoria = value;
            }
        }
    }
}
