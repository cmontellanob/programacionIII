using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConexionSQLServer:IConexionBD
    {

        private String host;
        private String puerto;
        private String usuario;
        private String contrasena;

        public ConexionSQLServer()
        {
            this.host = "localhost";
            this.puerto = "1433";
            this.usuario = "postgres";
            this.contrasena = "123";
        }

    public void conectar()
        {
            // Aqui puede ir código JDBC
            Console.WriteLine("Se conectó a SQLServer");

        }

    public void desconectar()
        {
            Console.WriteLine("Se desconectó de SQLServer");
        }

        public String getHost()
        {
            return host;
        }

        public void setHost(String host)
        {
            this.host = host;
        }

        public String getPuerto()
        {
            return puerto;
        }

        public void setPuerto(String puerto)
        {
            this.puerto = puerto;
        }

        public String getUsuario()
        {
            return usuario;
        }

        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        public String getContrasena()
        {
            return contrasena;
        }

        public void setContrasena(String contrasena)
        {
            this.contrasena = contrasena;
        }

    }
}
