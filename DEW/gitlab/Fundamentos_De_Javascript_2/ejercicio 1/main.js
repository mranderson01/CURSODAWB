const DOM = {
    obtValor: document.getElementById("obtValor"),
    mostrarDatos: document.getElementById("mostrarDatos"),
    formulario: document.getElementById("formulario"),
    error: document.getElementById("error")
}

const mostrarDivisores =(e)=>{
    e.preventDefault()
    let valorNumeral=parseInt(DOM.obtValor.value); 

    /*Limpiar zona de errores */
    [...DOM.error.children].forEach(child=>{
        DOM.error.removeChild(child);
    })

    /*¿Es Numero? */
    if (valorNumeral==NaN) {
        DOM.error.insertAdjacentHTML="<mark>Se tiene que introducir un número.</mark>"
        return;
    }

    /*Limpiar divisores */
    [...DOM.mostrarDatos.children].forEach(child=>{
        DOM.mostrarDatos.removeChild(child)
    })
  
    
    const listaDivisores=[];
    for (let index = 1; index <= valorNumeral; index++) { 
        let divisor=valorNumeral/index;
        if (index % 2 == 0 && Number.isInteger(divisor)) {
            listaDivisores.push(divisor)
        }
    }
    /**Insertar en el primer index el numero introducido */
    listaDivisores.splice(0,0,valorNumeral)

    /*pintar los divisores */
    listaDivisores.forEach(divisor=>{
        let h5=document.createElement("h5"); 
        h5.innerHTML=`<strong>${divisor} es un divisor</strong>`;
        DOM.mostrarDatos.appendChild(h5); 
    })                        
}
DOM.formulario.addEventListener("click",mostrarDivisores)