﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
       // public static string CN = ConfigurationManager.ConnectionStrings["miconexion"]?.ConnectionString;
        public static string CN = "Data Source=.;Initial Catalog=DBVENTAS_WEB;Integrated Security=True";
        

       
    }
}
