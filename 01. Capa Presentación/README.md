# Servicio WCF y Base de Datos - Desarrollo:

[![N|Solid](https://www.cmceledon.com/Recursos/assets/img/vegas-logo.png)](https://www.cmceledon.com/)

----



# Carlos Mario Celedón Rodelo


```sh
- Desarrollador Senior de Software - www.cmceledon.com
- Bogotá, Cundinamarca
- carlos@cmceledon.com
- 3004559711

```


---

### La aplicación consistirá en la gestión de Notas para estudiantes y profesor. Las opciones que se implementaron son:
* Interfaz web: http://bps.cmceledon.com/
* Servicio (WCF): http://bpsapi.cmceledon.com/
Aplicación web .NET utilizando WCF para realizar operaciones CRUD sobre una base de datos en SQL Server. 
Esquema de base de datos consiste en tres tablas que son:
- Estudiante: id, nombre
- Nota: id, nombre, idProfesor, idEstudiante, valor
- Profesor: id, nombre
- [![N|Solid](https://www.cmceledon.com/Recursos/bps/Tablas.png)](https://www.cmceledon.com/)
  -  --
### Notas importante:
- Algunas consultas a la base de datos se realizaron con procedimientos almacenados (objetos SQL) para evitar
consultas RAW SQL en el código.
- Arquitectura Domain-driven design (DDD)
- NLog https://nlog-project.org/ ExceptionHandlerAttribute, para la captura de errores para el Servicio WCF, Registro de eventos, ETC..
- Uso de Enumerators
