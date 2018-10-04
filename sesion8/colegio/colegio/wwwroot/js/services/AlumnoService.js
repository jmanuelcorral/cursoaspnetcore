import { httpService } from './httpService.js';

var OperacionesAlumno = () => {
    /*ESQUEMA ALUMNO
     {
      "id": "00000000-0000-0000-0000-000000000000",
      "nombre": null,
      "apellidos": null,
      "fechaNacimiento": null,
      "email": null,
      "cursoId": 0
    }

     */
    return {
        pintaListaAlumnos: (alumnos) => { 
            alumnos.forEach(element => {
              document.write(element.id);
              document.write(element.nombre);
              document.write(element.apellidos);
              document.write(element.fechaNacimiento);
              document.write(element.email);  
            });
        },
        pintaAlumno: (alumno) => console.log(alumno.id)
    };
};



httpService().get("http://localhost:5000/api/alumno", OperacionesAlumno().pintaListaAlumnos);
//httpService("/api/alumno").po
//httpService("/api/alumno").get(OperacionesAlumno().pintaAlumno, '1');



