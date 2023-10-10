/**
 * Define un código javascript que detecte si se dispone de una webcam y de un dispositivo de salida
    de audio. Se mostrará un mensaje tanto si se tiene como si no. Trate de ejecutar el mismo código
    en distintos navegadores para detectar diferencias en el comportamiento.
 */

// Verificar si el navegador admite la API mediaDevices
if (navigator.mediaDevices && navigator.mediaDevices.enumerateDevices) {
    // Enumerar los dispositivos multimedia disponibles
    navigator.mediaDevices.enumerateDevices()
      .then((devices) => {
        var hasVideoInput,hasAudioOutput = false;
  
        devices.forEach((device) => {
          if (device.kind === 'videoinput') hasVideoInput = true; 
          else if (device.kind === 'audiooutput') hasAudioOutput = true; 
        });
  
        // Comprobar si se encontró una cámara web y un dispositivo de salida de audio
        if (!hasVideoInput) console.log("El dispositivo no tiene una cámara web."); 
        if (hasVideoInput) console.log("El dispositivo tiene una cámara web.");
        
        if (!hasAudioOutput) console.log("El dispositivo no tiene un dispositivo de salida de audio.");
        if (hasAudioOutput) console.log("El dispositivo tiene un dispositivo de salida de audio.");

      })
      .catch((err) => console.error("Error al enumerar los dispositivos multimedia: " + err.name + ": " + err.message));
  } else console.error("La API mediaDevices no es compatible en este navegador.");
  
  /**
   * RESPUESTA: Comprobe que en FIREFOX, MICROSOFT EDGE y CHROME dan informacion sobre tiene tiene camara o audio cada dispositivo que detecta el navegador
   */