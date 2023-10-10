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

    //Si es de tipo input tagName: "INPUT"
    if (e.target.tagName=="INPUT") {
        let valorCalculadora = e.target.value;          
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

const resolverResultado = ()=>{
    let datosPantalla=DOM.datosPantalla.textContent;
    if (datosPantalla[0]=="√") {
        let numero = "";
        for (let index = 1; index < datosPantalla.length; index++) {
            if (datosPantalla[index]==".") {
                DOM.error.innerText="ERROR!!. No puede tener un punto en esta operacion. Vuelve a intentarlo."
                limpiarPantalla();
                index=datosPantalla.length;
                return;
            }
            numero+=datosPantalla[index];
        }

        let resultado=Math.sqrt(parseInt(numero))
        return resultado;
    } 
    return eval(datosPantalla);
}



const mostrarResultado = (e)=>{
    e.preventDefault();
    
    resultado=resolverResultado();
     
    limpiarPantalla(e);

    DOM.datosPantalla.textContent=resultado;
}

const resolverRaiz=(e)=>{
    e.preventDefault();

    limpiarPantalla(e);

    let resultado = Math.random() * (100-1) + 1;
    
    DOM.datosPantalla.textContent=resultado.toPrecision(2); 
}

const resolverArcocoseno = (e) =>{
    e.preventDefault();
    let numeroPantalla = DOM.datosPantalla.textContent
    if (numeroPantalla=="") {
        
    }
    
    numeroPantalla = parseFloat(DOM.datosPantalla.textContent);
    
    limpiarPantalla(e);

    let resultArcoCoseno=Math.acos(numeroPantalla).toPrecision(5);

    DOM.datosPantalla.textContent=resultArcoCoseno;
}


const calcular = (e) => { 
    e.preventDefault();   
    let tecla = e.target.value; 
    
    switch (tecla) {
        case "C":
            limpiarPantalla(e);
            break;
        case "=":
            mostrarResultado(e);        
            break;
        case "rand":
            resolverRaiz(e);
            break;
        case "AC":
            resolverArcocoseno(e);
            break;
        default:
            pintarCaracteres(e);
            break;
    }    
}

DOM.tabla.addEventListener("click",calcular) 
