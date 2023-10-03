const DOM = {
    form1: document.querySelector("#form1"),
    nota: document.querySelector("#nota"),
    error: document.querySelector("#error"),
    mensaje: document.querySelector("#mensaje")
}

const obtenerNota = (e) =>{ 
    e.preventDefault()

    const childrenMensaje=DOM.mensaje.children;
    [...childrenMensaje].every(child=>{
        DOM.mensaje.removeChild(child)
    })
    const childrenError= DOM.error.children;
    [...childrenError].every(child=>{
        DOM.error.removeChild(child)
    })

    const nota=DOM.nota.value;  
    const strong = document.createElement("strong");
    const parrafo=document.createElement("p"); 
    switch (true) {     
        
        case nota=="":            
            parrafo.textContent="No se introdujo un número. Indique un numero entre 0 - 10"
            parrafo.style="color:red;"
            DOM.error.appendChild(parrafo)
            break;
        case nota<0 || nota>10.1:
            parrafo.textContent="ERROR! - Indique un número del rango de 0 a 10."
            parrafo.style="color:red; background-color:black; padding: 5px; margin-top:5px;"
            DOM.error.appendChild(parrafo);
            break;
        case nota>=0 && nota<5:            
            strong.style="color:red; background-color:black; padding: 5px; margin-top:5px;"
            strong.textContent="Suspenso"
            DOM.mensaje.appendChild(strong);
            break;
        case nota>=5 && nota<7: 
            strong.style="color:yellow; background-color:black; padding: 5px; margin-top:5px;"
            strong.textContent="Aprobado"
            DOM.mensaje.appendChild(strong);
            break;
        case nota>=7 && nota<9: 
            strong.style="color:white; background-color:black; padding: 5px; margin-top:5px;"
            strong.textContent="Notable"
            DOM.mensaje.appendChild(strong);
            break;
        case nota>=9 && nota<=10: 
            strong.style="color:green; background-color:black; padding: 5px; margin-top:5px;"
            strong.textContent="Sobre-Saliente"
            DOM.mensaje.appendChild(strong);
            break;            
        default:            
            break;
    }

}
DOM.form1.addEventListener("submit",obtenerNota)
 
