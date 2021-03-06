﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Veiculo
    {
        #region atributos
        private string placa;
        private int lotacao;

        #endregion

        #region propriedades
        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
        }

        public int Lotacao
        {
            get
            {
                return lotacao;
            }

            set
            {
                lotacao = value;
            }
        }

        #endregion

        #region construtor
        public Veiculo(string placa, int lotacao)
        {
            this.Placa = placa;
            this.Lotacao = lotacao;
        }

        #endregion

        #region métodos
        public string toString()
        {
            return "Placa: " + Placa + "    |   " + "Capacidade: " + Lotacao;
        }
        #endregion


    }
}
