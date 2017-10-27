using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionHotel.Modelo
{
    class Hotel
    {
        private int id;
        private string dirección;
        private string nombre;

        public int Id_hotel
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Direccion
        {
            get
            {
                return Direccion;
            }
            set
            {
                Direccion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
    }
}
