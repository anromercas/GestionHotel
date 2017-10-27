using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionHotel.Modelo
{
    class Actividades
    {
        private int id;
        private string nombre, descripcion;

        public int Id_actividades
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
        public string NombreActividad
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
