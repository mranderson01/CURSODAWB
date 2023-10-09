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
        /*if (longDato>=1) {
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
            
        }*/
        DOM.datosPantalla.innerHTML+=`${valorCalculadora}`;
    }
    
}


const limpiarPantalla = (e)=>{
    e.preventDefault();
    //Borrar los nodos de contenedor de pantalla
    let childsdatoPantalla=DOM.datosPantalla.childNodes;

    childsdatoPantalla.forEach(child=>{
        DOM.datosPantalla.removeChild(child)
    })
}


const resolverCalculo = (e)=>{
    e.preventDefault();

    let datosPantalla=DOM.datosPantalla.textContent;
    let resultado=eval(datosPantalla);
    limpiarPantalla(e);
    DOM.datosPantalla.textContent=resultado;
}


const calcular = (e) => { 
    e.preventDefault();   
    let tecla = e.target.value; 
    
    switch (tecla) {
        case "C":
            limpiarPantalla(e);
            break;
        case "=":
            resolverCalculo(e);        
            break;
        default:
            pintarCaracteres(e);
            break;
    }    
}

DOM.tabla.addEventListener("click",calcular) 
