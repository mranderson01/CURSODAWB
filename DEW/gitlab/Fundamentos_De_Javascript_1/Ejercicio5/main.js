const DOM = {
    mes: document.getElementById("seleccionar"),
    temporada: document.getElementById("temporada")
}

const estacion = (e) => {
    e.preventDefault();
    const mes=DOM.mes.value
    let estacion="";
    switch (mes) {
        case "Enero":
            estacion="Invierno"
            break;
        case "Febrero":
            estacion="Invierno"
            break;
        case "Marzo":
            estacion="Invierno"
            break;
        case "Abril":
            estacion="Primavera"
            break;
        case "Mayo":
            estacion="Primavera"
            break;
        case "Junio":
            estacion="Primavera"
            break;
        case "Julio":
            estacion="Verano"
            break;
        case "Agosto":
            estacion="Verano"
            break;
        case "Septiembre":
            estacion="Verano"
            break;
        case "Octubre":
            estacion="Otoño"
            break; 
        case "Noviembre":
            estacion="Otoño"
            break; 
        case "Diciembre":
            estacion="Otoño"
            break; 
    }
    DOM.temporada.value=estacion;
}

DOM.mes.addEventListener("change",estacion);
