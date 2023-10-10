/**
 * 
 * Define un código javascript que muestre cuántos Gigas de RAM dispone el dispositivo y cuántos
    núcleos/procesadores tiene. Trate de ejecutar el mismo código en distintos navegadores para
    detectar diferencias en el comportamiento.
 */

    if ("deviceMemory" in navigator && "hardwareConcurrency" in navigator) {
        // Obtener la cantidad de RAM en gigabytes
        var ramGB = navigator.deviceMemory;
        
        // Obtener el número de núcleos/procesadores
        var numCores = navigator.hardwareConcurrency;
        
        // Mostrar la información en la consola o en la página web
        console.log("Cantidad de RAM: " + ramGB + " GB");
        console.log("Número de núcleos/procesadores: " + numCores);
      } else {
        console.error("La información sobre RAM y núcleos no está disponible en este navegador.");
      }

/**
 * ESTO se ve en Chrome
 * Cantidad de RAM: 8 GB
   Número de núcleos/procesadores: 4 
 */

/** 
 * En FIREFOX: 
 * La información sobre RAM y núcleos no está disponible en este navegador. main.js:19:17 
*/

/**
 * EN MICROSOFT: 
 *  Cantidad de RAM: 8 GB
     Número de núcleos/procesadores: 4 
 */