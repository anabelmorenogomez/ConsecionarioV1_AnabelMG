using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecionarioV1_AnabelMG
{
    public  class Vehículo
    {
        // Constantes 

        // Miembros Privados 
        private string _marca;
        private string _modelo;

        // Constructores 
        public Vehículo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        // Propiedades 
        public string Marca
        {
            get { return _marca; }
            set {
                // TODO: Proporcionar seguridad y protección al miembro -- Marca
                _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set {
                // TODO: Proporcionar seguridad y protección al miembro -- Modelo
                _modelo = value; }
        }
        // Métodos Públicos 

        // Métodos Privados 

    }
}
