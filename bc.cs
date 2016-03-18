namespace JCDM
{
    public class ClaseProyectoVial
    {
        ///////////////////////////////////////////////
        struct ProyectoTransito
        {
            public string Nombre;
            public string Ciudad;
            public int IDProyecto;
            public string Formulador;
            public string Contacto_Formulador;
            public string Entidad;
            public int Numero_Accesos;
            public List<Acceso_Vial> Lista_Accesos_Viales;
        }
        struct Acceso_Vial
        {
            public string Nombre_AccesoVial;//OESTE, ESTE, NORTE Y SUR
            public string Localizacion_Acceso;
            public int ID_AccesoVial;
            public int Numero_Carriles;
            public List<Carril_Vial> Lista_Carriles_Viales;
        }
        struct Carril_Vial
        {
            public string NombreCarrilVial;
            public int Numero_Movimientos;
            public List<Movimiento_Vial> Lista_Movimientos_Viales;
        }
        struct Movimiento_Vial
        {
            public string Nombre_Movimiento_Vial;
            public int Numero_Aforos;
            // public List<Aforo_Vial> Lista_Aforos_x_Movimiento; creo que sobra
        }
        struct Aforo_Vial
        {
            public string Nombre_Aforo;
            public string Aforador;
            public int Duracion_Horas;
            public int Periodo_Conteo_Minutos;
            public List<int> Veh_mixtos;
            public int VHMD;
            public double FHMD;
            
        }
        /////////////////////////////////////////////////////
    }
    public class test
    {
        public ProyectoTransito proyectox = new ProyectoTransito();
        proyectox.Nombre = "PAGINA FACEBOOK";
        proyectox.Ciudad = "MEXICO";
        proyectox.IDProyecto = "123";
        proyectox.Formulador = "CARLOS FAST TAG";
        proyectox.Contacto_Formulador = ".NET ";
        proyectox.Entidad = "facebook";
        proyectox.Numero_Accesos = 3;
        ///
        proyectox.Lista_Accesos_Viales Mis_accesos = new proyectox.Lista_Accesos_Viales( proyectox.Numero_Accesos );
        //añadimos las propiedades de cada acceso
        
        //
        // Acceso 0
        //
        Mis_accesos[0].Nombre_AccesoVial = "Norte";//OESTE, ESTE, NORTE Y SUR
        Mis_accesos[0].Localizacion_Acceso = "calle 33 carrera 22";
        Mis_accesos[0].ID_AccesoVial = 0;
        Mis_accesos[0].Numero_Carriles = 2;
        Mis_accesos[0].Lista_Carriles_Viales Carriles0 = new Mis_accesos[0].Lista_Carriles_Viales( Mis_accesos[0].Numero_Carriles );
        
        //añadimos las propiedades de cada carril del acceso 0
        Carriles0[0].NombreCarrilVial = "Derecho";
        Carriles0[0].Numero_Movimientos = 2;
        Carriles0[0].Lista_Movimientos_Viales Mov_por_Carril0 = new Carriles0[0].Lista_Movimientos_Viales( Carriles0[0].Numero_Movimientos );
        //añadimos las propiedades de cada movimiento por carril del acceso 0
        Mov_por_Carril0[0].Nombre_Movimiento_Vial = "giro derecha";
        Mov_por_Carril0[0].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[0] ); //añadimos a la lista Mov_por_Carril0
        Mov_por_Carril0[1].Nombre_Movimiento_Vial = "sin giro";
        Mov_por_Carril0[1].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[1] ); //añadimos a la lista Mov_por_Carril0
        Carriles0.Add( Carriles0[0] ); //añadimos a la lista Carriles0 elemento 0
        
        //añadimos las propiedades de cada carril del acceso 1
        Carriles0[1].NombreCarrilVial = "Derecho";
        Carriles0[1].Numero_Movimientos = 2;
        Carriles0[1].Lista_Movimientos_Viales Mov_por_Carril0 = new Carriles0[1].Lista_Movimientos_Viales( Carriles0[1].Numero_Movimientos );
        //añadimos las propiedades de cada movimiento por carril del acceso 0
        Mov_por_Carril0[0].Nombre_Movimiento_Vial = "giro derecha";
        Mov_por_Carril0[0].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[0] ); //añadimos a la lista Mov_por_Carril0
        Mov_por_Carril0[1].Nombre_Movimiento_Vial = "sin giro";
        Mov_por_Carril0[1].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[1] ); //añadimos a la lista Mov_por_Carril0
        Carriles0.Add( Carriles0[0] ); //añadimos a la lista Carriles0 elemento 1
        
        //
        // Acceso 1
        //
        Mis_accesos[1].Nombre_AccesoVial = "sur";//OESTE, ESTE, NORTE Y SUR
        Mis_accesos[1].Localizacion_Acceso = "calle 33 carrera 22";
        Mis_accesos[1].ID_AccesoVial = 1;
        Mis_accesos[1].Numero_Carriles = 2;
        Mis_accesos[1].Lista_Carriles_Viales Carriles0 = new Mis_accesos[1].Lista_Carriles_Viales( Mis_accesos[1].Numero_Carriles );
        //añadimos las propiedades de cada carril del acceso 0
        Carriles0[0].NombreCarrilVial = "Derecho";
        Carriles0[0].Numero_Movimientos = 2;
        Carriles0[0].Lista_Movimientos_Viales Mov_por_Carril0 = new Carriles0[0].Lista_Movimientos_Viales( Carriles0[0].Numero_Movimientos );
        //añadimos las propiedades de cada movimiento por carril del acceso 0
        Mov_por_Carril0[0].Nombre_Movimiento_Vial = "giro derecha";
        Mov_por_Carril0[0].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[0] ); //añadimos a la lista Mov_por_Carril0
        Mov_por_Carril0[1].Nombre_Movimiento_Vial = "sin giro";
        Mov_por_Carril0[1].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[1] ); //añadimos a la lista Mov_por_Carril0
        Carriles0.Add( Carriles0[0] ); //añadimos a la lista Carriles0 elemento 0
        
        //añadimos las propiedades de cada carril del acceso 1
        Carriles0[1].NombreCarrilVial = "Derecho";
        Carriles0[1].Numero_Movimientos = 2;
        Carriles0[1].Lista_Movimientos_Viales Mov_por_Carril0 = new Carriles0[1].Lista_Movimientos_Viales( Carriles0[1].Numero_Movimientos );
        //añadimos las propiedades de cada movimiento por carril del acceso 0
        Mov_por_Carril0[0].Nombre_Movimiento_Vial = "giro derecha";
        Mov_por_Carril0[0].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[0] ); //añadimos a la lista Mov_por_Carril0
        Mov_por_Carril0[1].Nombre_Movimiento_Vial = "sin giro";
        Mov_por_Carril0[1].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[1] ); //añadimos a la lista Mov_por_Carril0
        Carriles0.Add( Carriles0[1] ); //añadimos a la lista Carriles0 elemento 1
        
        //
        // Acceso 2
        //
        Mis_accesos[2].Nombre_AccesoVial = "este";//OESTE, ESTE, NORTE Y SUR
        Mis_accesos[2].Localizacion_Acceso = "calle 33 carrera 22";
        Mis_accesos[2].ID_AccesoVial = 1;
        Mis_accesos[2].Numero_Carriles = 2;
        Mis_accesos[2].Lista_Carriles_Viales Carriles0 = new Mis_accesos[2].Lista_Carriles_Viales( Mis_accesos[2].Numero_Carriles );
        //añadimos las propiedades de cada carril del acceso 0
        Carriles0[0].NombreCarrilVial = "Derecho";
        Carriles0[0].Numero_Movimientos = 2;
        Carriles0[0].Lista_Movimientos_Viales Mov_por_Carril0 = new Carriles0[0].Lista_Movimientos_Viales( Carriles0[0].Numero_Movimientos );
        //añadimos las propiedades de cada movimiento por carril del acceso 0
        Mov_por_Carril0[0].Nombre_Movimiento_Vial = "giro derecha";
        Mov_por_Carril0[0].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[0] ); //añadimos a la lista Mov_por_Carril0
        Mov_por_Carril0[1].Nombre_Movimiento_Vial = "sin giro";
        Mov_por_Carril0[1].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[1] ); //añadimos a la lista Mov_por_Carril0
        Carriles0.Add( Carriles0[0] ); //añadimos a la lista Carriles0 elemento 0
        
        //añadimos las propiedades de cada carril del acceso 1
        Carriles0[1].NombreCarrilVial = "Derecho";
        Carriles0[1].Numero_Movimientos = 2;
        Carriles0[1].Lista_Movimientos_Viales Mov_por_Carril0 = new Carriles0[1].Lista_Movimientos_Viales( Carriles0[1].Numero_Movimientos );
        //añadimos las propiedades de cada movimiento por carril del acceso 0
        Mov_por_Carril0[0].Nombre_Movimiento_Vial = "giro derecha";
        Mov_por_Carril0[0].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[0] ); //añadimos a la lista Mov_por_Carril0
        Mov_por_Carril0[1].Nombre_Movimiento_Vial = "sin giro";
        Mov_por_Carril0[1].Numero_Aforos = 1;
        Mov_por_Carril0.Add( Mov_por_Carril0[1] ); //añadimos a la lista Mov_por_Carril0
        Carriles0.Add( Carriles0[2] ); //añadimos a la lista Carriles0 elemento 1
        
        
    }
}