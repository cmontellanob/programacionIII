﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class CheckFacade
    {
      
            private AvionApi avionAPI;
            private HotelApi hotelAPI;

            public CheckFacade()
            {
                avionAPI = new AvionApi();
                hotelAPI = new HotelApi();
            }

            public void buscar(String fechaIda, String fechaVuelta, String origen, String destino)
            {
                avionAPI.buscarVuelos(fechaIda, fechaVuelta, origen, destino);
                hotelAPI.buscarHoteles(fechaIda, fechaVuelta, origen, destino);
            }
        

    }
}
