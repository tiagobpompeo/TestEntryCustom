using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestEntry
{
    public class VModel : BaseViewModel
    {
        private string _textoSaida;

        public string TextoSaida
        {
            get { return this._textoSaida; }
            set { SetValue(ref this._textoSaida, value); }
        }


        public VModel()
        {
            string a = "RUA DAS URUGUAIAS ARGENTINAS E PARAGUAIS RSADSDFSFDFFSF asdfasdfafadadasdadadasdasdasdasdasdasdasdasd";
            TextoSaida = a.ToLower();
        }
    }
}