const DOM = {
    obtValor: document.getElementById("obtValor"),
    mostrarDato: document.getElementById("mostrarDatos"),
    formulario: document.getElementById("formulario")
}

const mostrarDivisores =(e)=>{
    e.preventDefault()
    const valorNumeral=DOM.obtValor.value;
    console.log(valorNumeral)

    let parrafo=document.createElement("p")
    parrafo.innerHTML=`${} es un divisor`
}
DOM.formulario.addEventListener("click",mostrarDivisores)