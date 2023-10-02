const DOM = {
    form1: document.querySelector("#form1"),
    nota: document.querySelector("#nota"),
    error: document.querySelector("#error"),
    mensaje: document.querySelector("#mensaje")
}

const obtenerNota = (e) =>{ 
    e.preventDefault()
    const nota=DOM.nota.value;
    if (nota>=0 && nota<=5) {    
        const strong=document.createElement("strong");
        strong.style="color:red;"
        strong.textContent="Suspenso"
        DOM.mensaje.appendChild(strong);
    }
}
DOM.form1.addEventListener("submit",obtenerNota)
 
