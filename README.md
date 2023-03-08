# **Reto de programacion N1**

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

Desarrolle 2 microservicios de Python y 1 en C#. 

*******

<div id='problemas'/> 

### **2. Problemas**

El microservicio de C# no logre conectarlo a los clientes con IP publica, solo se puede evidenciar que funciona en redes locales por medio del localhost o por su IP privada.
Desarrolle un API en Node.js usando como base la del laboratorio, sin embargo, no se puede conectar a C#, por eso incluyo un tercer codigo de servidor en Python, el codigo de ambos se encuentra en la carpeta zOld.
Por lo que entiendo este codigo de C# tiene un parametro en launchSettings.json llamado applicationUrl que es el URL del cliente, pero no me funciona aceptando todos (0.0.0.0) o con la IP publica del cliente, solo la privada en la misma red.

*******

<div id='resources'/> 

### **3. Recursos**

Utilice los conocimientos dados en el Laboratorio 1, y el archivo ejemplo que produce Visual Studio para comunicaciones Grcp con C#, informacion en internet de C# fue extremadamente escasa, variada y poco util.

*******

<div id='development'/>  

### **4. Desarrollo**

Desarrolle los codigos de los microservicios el fin de semana del 24 de febrero e investigue sobre Node.js, el laboratorio lo desarrolle el sabado 4 de marzo que por fin tenia acceso a AWS, con el laboratorio pude darme una base de entendimiento del tema e adapte enteramente un microservicio funcional, intente aprender sobre la implementacion de C# pero no encontre forma alguna luego de dias de intentos, asi que hice los otros dos microservicios en Python y un API en Node.js. El dia martes 7 comprobe el funcionamiento con Postman e intente una vez mas con C# lo cual me funciono, logre adaptar los conocimientos de los intentos anteriores para crear un microservicio funcional, sin embargo no conte con la disponibilidad de tiempo suficiente ni pude encontrar en internet como lograr que reciba peticiones publicas de la red.
El servicio de inventario puede revisar si el elemento que se pregunta esta disponible, retorna si lo esta y su cantidad.
El servicio de pago investiga en una base de datos "externa" si la targeta indicada esta correcta y existe, responde si lo es o no.
El servicio de envio guarda en un documento la direccion de la casa y que objeto se le va a enviar.
Y luego se escribe en el servicio inventario su segundo metodo para modificar el inventario, ya que se vendio y envio el objeto.

*******

<div id='deployment'/>  

### **5. Despliegue**

Despliego los servicios de Python en 2 instancias de AWS y 1 local de C#, cada instancia se le ingresan los comandos que estan en su carpeta en el .txt, de esta forma se inicia correctamente los servicios con los requerimientos instalados. Ya se pueden probar por medio de Postman, ingresando su IP publica con el puerto :8080, para el servicio de C# se debe editar en launchSettings.json el applicationUrl como la IP privada actual de la maquina que realizara las pruebas de Postman o localhost, en postman la misma IP.
A continuacion escribire los comandos de cada maquina, aunque ya estan incluidos en cada carpeta, las lineas vacias indican una pausa, lo que esta debajo debe copiarse por su cuenta.

*InventoryService:*
```sh
sudo apt update && sudo apt upgrade -y && sudo apt-get install python3 && sudo apt-get install python3-pip -y
```
```sh
sudo python3 -m pip install grpcio
sudo python3 -m pip install grpcio-tools
sudo git clone https://github.com/pmayavi/TopicosTelematica-2023-1.git
cd TopicosTelematica-2023-1/Back/InventoryService/src/
sudo python3 -m grpc_tools.protoc -I ../protobufs --python_out=. --pyi_out=. --grpc_python_out=. ../protobufs/Service.proto
sudo python3 inventory.py
```
```sh
sudo git pull && \
sudo python3 -m grpc_tools.protoc -I ../protobufs --python_out=. --pyi_out=. --grpc_python_out=. ../protobufs/Service.proto && \
sudo python3 inventory.py
```

*PaymentService:*
```sh
sudo apt update && sudo apt upgrade -y && sudo apt-get install python3 && sudo apt-get install python3-pip -y
```
```sh
sudo python3 -m pip install grpcio
sudo python3 -m pip install grpcio-tools
sudo git clone https://github.com/pmayavi/TopicosTelematica-2023-1.git
cd TopicosTelematica-2023-1/Back/PaymentService/src/
sudo python3 -m grpc_tools.protoc -I ../protobufs --python_out=. --pyi_out=. --grpc_python_out=. ../protobufs/Service.proto
sudo python3 payment.py
```
```sh
sudo git pull && \
sudo python3 -m grpc_tools.protoc -I ../protobufs --python_out=. --pyi_out=. --grpc_python_out=. ../protobufs/Service.proto && \
sudo python3 payment.py
```

*ShipmentService:*
```sh
sudo apt update && sudo apt upgrade -y
```
```sh
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
sudo apt-get update && sudo apt-get install -y dotnet-sdk-6.0
```
```sh
sudo apt-get update && sudo apt-get install -y aspnetcore-runtime-6.0
```
```sh
sudo apt-get install -y dotnet-runtime-6.0
sudo git clone https://github.com/pmayavi/TopicosTelematica-2023-1.git
cd TopicosTelematica-2023-1/Back/ShipmentService/ShipmentService/
sudo dotnet build
sudo dotnet run
```

*******
