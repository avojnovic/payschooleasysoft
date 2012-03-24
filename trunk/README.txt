
 ==========================================
 ========== PAY SCHOOL EASY SOFT ==========
 ==========================================

Requerimientos de Software:

 - Microsoft SQL Server 2005 (Express)
 - Microsoft SQL Server Management Studio Express
 - Microsoft Visual Studio 2008
 - Microsoft Visual C#
 - Internet Explorer 7 (o superior) o Mozilla Firefox 3.5

Pasos para la puesta en marcha del entorno
de ejecución parcial de Pay School Easy Soft:

1- Copiar del CD-ROM al directorio raíz la carpeta "PaySchoolEasySoft".
2- Desde el SQL Server Management Studio Express abrir y ejecutar el archivo "scriptCreate.sql"
   ubicado en el directorio ../PaySchoolEasySoft/Script para crear la Base de Datos y las tablas
   correspondientes.
3- Desde el SQL Server Management Studio Express abrir y ejecutar el archivo "scriptInsert.sql"
   ubicado en el directorio ../PaySchoolEasySoft/Script para agregar a la Base de Datos, generada
   en el paso anterior, el juego de datos de prueba.
4- Ejecutar la solucion "PaySchoolEasySoft.sln" ubicada en el directorio ../PaySchoolEasySoft.
5- Una vez dentro del entorno de desarrollo Visual Studio 2008, abrir la clase "Datos.cs" ubicada
   dentro del proyecto "CapaDatos" y modificar el String de Conexión a la Base de Datos; cambiando
   el Data Source por el que corresponda (nombre del servidor donde se aloja la Base de Datos).
6- Iniciar depuración para probar la aplicación.


Nota: 
     Para la prueba del sistema como usuario de tipo tutor utilice los siguientes datos: 
        Nombre de Usuario: santiagoalegre@hotmail.com
        Contraseña: 1

     Para la prueba del sistema como usuario de tipo administrador utilice los siguientes datos:
        Nombre de usuario: admin@fasta.edu.ar
        Contraseña: admin