using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAula.Modelo
{
    public class Calculos
    {
        public Double n1;
        public Double n2;
        public String op;
        public String resposta;


        public void calcular()
        {

            if (this.op.Equals("+"))
                this.resposta = (this.n1 + this.n2).ToString();
            if (this.op.Equals("-"))

                this.resposta = (this.n1 - this.n2).ToString();

            if (this.op.Equals("*"))
                this.resposta = (this.n1 * this.n2).ToString();

            if (this.op.Equals("/"))
                this.resposta = (this.n1 / this.n2).ToString();
        }
    }
}

