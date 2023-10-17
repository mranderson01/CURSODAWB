const DOM = {
    altoDisponible: document.getElementById("altoDisponible"),
    anchoDisponible:document.getElementById("anchoDisponible"),
    altoTotal:document.getElementById("altoTotal"),
    anchoTotal:document.getElementById("anchoTotal"),
    profundidadColor:document.getElementById("profundidadColor"),
    resolucionBitXPixel:document.getElementById("resolucionBitXPixel"),

    altoExterior:document.getElementById("altoExterior"),
    anchoExterior:document.getElementById("anchoExterior"),
    CoorXRespePantalla:document.getElementById("CoorXRespePantalla"),
    CooryRespePantalla:document.getElementById("CooryRespePantalla"),
    visitado:document.getElementById("visitado"), 


}

const obtInfoPantalla = ()=>{
    let altoDisponible = new Screen().availHeight;
    let anchoDisponible = new Screen().availWidth;
    let altoTotal = new Screen().height;
    let anchoTotal = new Screen().width;
    let profundidadColor = new Screen().colorDepth;
    let resolucionBitXPixel = new Screen().pixelDepth;

    DOM.altoDisponible.innerText+=altoDisponible;
    DOM.anchoDisponible.innerText+=anchoDisponible;
    DOM.altoTotal.innerText+=altoTotal;
    DOM.anchoTotal.innerText+=anchoTotal;
    DOM.profundidadColor.innerText+=profundidadColor;
    DOM.resolucionBitXPixel.innerText+=resolucionBitXPixel;

    return `
    alto Disponible: ${altoDisponible};
    ancho Disponible: ${anchoDisponible};
    alto Total: ${anchoTotal};
    profundidad: ${profundidadColor}; 
    resolucion: ${resolucionBitXPixel}`
}


const obtInfoVentana =()=>{
    let altoExterior = window.innerHeight.toPrecision(5);
    let anchoExterior = window.innerWidth.toPrecision(5);
    let CoorXRespePantalla = window.screenX.toPrecision(5);
    let CooryRespePantalla = window.screenY.toPrecision(5);
    let longVisitas=window.history.length;

    DOM.altoExterior.innerText+=altoExterior;
    DOM.anchoExterior.innerText+=anchoExterior;
    DOM.CoorXRespePantalla.innerText+=CoorXRespePantalla;
    DOM.CooryRespePantalla.innerText+=CooryRespePantalla;
    DOM.visitado.innerText+=longVisitas;

    return ``
}


const ejecutarEjercicio=()=>{
    obtInfoPantalla();

}