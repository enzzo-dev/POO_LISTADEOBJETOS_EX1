using System;
using System.Collections.Generic;

namespace POO_LISTADEOBJETOS_EX1.classes
{
    public class Cartao
    {
        public string Titular{ get;set;}

        public int Numero{get;set;}

        public string Bandeira{get;set;}

        public string Vencimento{get;set;}


        private int cvv;
        public int Cvv{get{return cvv;}set{cvv = value;}}

        //Métodos
        public Cartao(){

        }

        public Cartao(string _titular , int _numero , string _bandeira , string _vencimento , int _cvv){
            Titular = _titular;
            Numero = _numero;
            Bandeira = _bandeira;
            Vencimento = _vencimento;
            Cvv = _cvv;
        }
    }
}