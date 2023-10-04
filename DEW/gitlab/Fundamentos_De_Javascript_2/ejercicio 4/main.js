const DOM = {
    tabla:document.getElementById("tabla"),
    contPantalla: document.getElementById("contPantalla"),
    datosPantalla: document.getElementById("datosPantalla"),
    btnEnviar: document.getElementById("btnEnviar"),
    error: document.getElementById("error")
}
//TODO: 
const pintarCaracteres = (e)=>{
    e.preventDefault();
    //console.log(e)

    //ver si el ultimo valor es numero o un signo
    let datosPantalla=DOM.datosPantalla.textContent;
    let longDato = datosPantalla.length;
    let ultimoCaracter=datosPantalla.charAt(longDato-1);
    if (longDato==1) {                
        if (Number.isNaN(ultimoCaracter)) {
            [...DOM.error.children].forEach(child=>{
                DOM.error.removeChild(child)
            })
            DOM.error.innerHTML="<mark>El primer numero tiene que ser un número.</mark>"            
        }
    }
    
    //Si es de tipo input 
    //tagName: "INPUT"    
    if (e.target.tagName=="INPUT") {
        let valorCalculadora = e.target.value;   
        if (longDato>=1) {
            if (ultimoCaracter == "*" && valorCalculadora=="*") 
            {
                console.log("Los dos ultimos caracteres son * y estan permitidos")
                return;
            }

            if (!Number.isNaN(parseFloat(ultimoCaracter)) && 
                Number.isNaN(parseFloat(valorCalculadora)))
            {
                console.log("el ultimo caracter no es un numero.")               
            }
            console.log("el primer y ultimo caracter son numeros")
            
        }
        DOM.datosPantalla.innerHTML+=`${valorCalculadora}`;
    }
    
}


const limpiarPantalla = (e)=>{
    e.preventDefault();
    //Borrar los nodos de contenedor de pantalla
    let childsContPantalla=DOM.contPantalla.childNodes;

    childsContPantalla.forEach(child=>{
        DOM.contPantalla.removeChild(child)
    })
}

const calcular = (e) => { 
    e.preventDefault();   
}



DOM.tabla.addEventListener("click",pintarCaracteres)
DOM.btnEnviar.addEventListener("click",calcular)
