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

    const nota=DOM.nota.value;
    if (nota>=0 && nota<5) {    
        const strong=document.createElement("strong");
        strong.style="color:red;"
        strong.textContent="Suspenso"
        DOM.mensaje.appendChild(strong);
    }
    if (nota>=5 && nota<7) {    
        const strong=document.createElement("strong");
        strong.style="color:blue;"
        strong.textContent="Aprobado"
        DOM.mensaje.appendChild(strong);
    }

}
DOM.form1.addEventListener("submit",obtenerNota)
 
