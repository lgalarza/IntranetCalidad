﻿using IntranetCalidad.Shared.ComponentModels;
using static CalidadDominioDTO.SeguridadDTO;

namespace IntranetCalidad.Validate
{
    //Clase para validar el menu que devuelve el login guardado en la sesion
    public class Validate
    {
        public Validate()
        {}
        public Boolean isValid(string page, MenuDTO[] menu)
        {
            if (menu is null)
            {
                return false;
            }
            var item = menu.SingleOrDefault(x => x.urlPagina == page);
            if(item == null)
            {
                return false;
            }
            return true;
            
        }
    }
}
