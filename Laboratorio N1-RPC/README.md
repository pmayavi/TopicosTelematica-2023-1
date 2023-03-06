# **Laboratorio N1**

**Curso:** Tópicos Especiales en Telemática <br>
**Título:** Comunicación entre Procesos Remotos: gRPC.<br>

*******

**Tabla de Contenido**

1. [Introducción](#introduction)
2. [Problemas](#problemas)
3. [Recursos](#resources)
4. [Desarrollo](#development) 
5. [Despliegue](#deployment) <br>

*******

<div id='introduction'/> 

### **1. Introducción**

Desarrolle 3 microservicios de python los cuales se comunican entre si por medio de un API Gateway de Node.js 


*******

<div id='problemas'/> 

### **2. Problemas**

Intente usar C#, se implementa de forma completamente unica a lo que he trabajado, sin embargo, no logro hacer la conexion con el API, no logro encontrar el por que ni una documentacion de como juntar Node como API y C# como microservicio, solo encuentro cursos de 7~ horas sobre el tema.
Adjunto el prototipo del metodo en C# en la carpeta TransactionService.
En el servicio de AWS me toco recrear unas 6 veces distintas las instancias, llave y grupo de seguridad por problemas fuera de mi control.

*******

<div id='resources'/> 

### **3. Recursos**

Solo utilice los conocimientos dados en el Laboratorio 1, ya que no encontre ayudas que me sirvieran en C# y que el semestre pasado me regaño el profesor por usar codigo de internet.

*******

<div id='development'/>  

### **4. Desarrollo**

Desarrolle los codigos de los microservicios el fin de semana del 24 de febrero e investigue sobre Node.js, el laboratorio lo desarrolle el sabado 4 de marzo que por fin tenia acceso a AWS, con el laboratorio pude darme una base de entendimiento del tema e adapte enteramente un microservicio funcional, intente aprender sobre la implementacion de C# pero no encontre forma alguna luego de dias de intentos, asi que hice los otros dos microservicios en Python.

*******

<div id='deployment'/>  

### **5. Despliegue**

Se edita el archivo de .env con las IPS adecuadas, o solo se edita en la instancia API. 
Despliego el servicio en 4 instancias de AWS, cada instancia se le ingresan los comandos que estan en su carpeta en el .txt, de esta forma se inicia correctamente el servicio, y se inicia el API, actualemnte en el main simplemente hace metodos a cada servicio pero se puede cambiar por una interfaz o aprender a usar postman, pero no es requerimiento del documento.

*******