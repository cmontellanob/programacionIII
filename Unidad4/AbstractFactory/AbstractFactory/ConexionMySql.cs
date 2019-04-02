using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConexionMySQL: IConexionBD
    {
        private String host;
        private String puerto;
        private String usuario;
        private String contrasena;

        public ConexionMySQL()
        {
            this.host = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.contrasena = "123";
        }


    public void conectar()
        {
            // Aqui puede ir código JDBC
            Console.WriteLine("Se conectó a MySQL");

        }

    public void desconectar()
        {
            Console.WriteLine("Se desconectó de MySQL");
        }

    public String toString()
        {
            return "ConexionMySQL [host=" + host + ", puerto=" + puerto + ", usuario=" + usuario + ", contrasena="
                    + contrasena + "]";
        }
    }

}
