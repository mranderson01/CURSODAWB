/**
 * Define un código javascript que te permita obtener la longitud y latitud del dispositivo desde donde
    se muestra la página. Trate de ejecutar el mismo código en distintos navegadores para detectar
    diferencias en el comportamiento.    
 */

    if ("geolocation" in navigator) {
        
        navigator.geolocation.getCurrentPosition(function(position) {

          let latitude = position.coords.latitude;
          let longitude = position.coords.longitude;

          console.log("Latitud: " + latitude + ", Longitud: " + longitude);
        }, function(error) {          
          console.error("Error al obtener la ubicación: " + error.message);
        });

      } else {  
        console.error("La geolocalización no está disponible en este navegador.");
      }
//RESPUESTA: 
//En MICROSOFT me aparece esta longitud y latitud: Latitud: 28.4512, Longitud: -16.289
// En Chrome y firefox ma aparece este: Latitud: 28.4596867, Longitud: -16.2906588
    