const DOM = {
    form: document.getElementById("form"),
    valor: document.getElementById("obtValor"),
    btnCalcular: document.getElementById("btnCalcular"),
    error: document.getElementById("error"),
    contResultado: document.getElementById("contResultado")
}

const calcularFibonacci = (e)=>{
    e.preventDefault();

     /*Limpiar zona de errores */
    [...DOM.error.children].forEach(child=>{
        DOM.error.removeChild(child);
    })

    
    if (parseInt(DOM.valor)==NaN) {
        DOM.error.innerHTML="<h1 style='color:red;'> No es un número</h1>"
    }

    let resultado=0;
    let cantMaxima=parseInt(DOM.valor.value);
    for (let index = 1; index <= cantMaxima; index++) {         
        resultado+=index;        
    }

    DOM.contResultado.innerHTML=`Resultado: <strong>${resultado}</strong>`    
}
DOM.btnCalcular.addEventListener("click", calcularFibonacci)