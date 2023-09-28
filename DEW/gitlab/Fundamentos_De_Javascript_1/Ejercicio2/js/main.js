//a) ¿Qué hace el siguiente código? ¿para que se utiliza typeof?
// alert(typeof())
//R: Sirven para saber el tipo de dato es un variable

const cadena = "cadena";
console.log("Ejercicio A")
console.log(typeof(cadena))

/**
 * b) Indica el valor que generan las siguientes expresiones y el tipo de datos de los mismos:
    a. 2 > 3 +2
    b. 1 + false +3.5
    c. 4 * true + 2
    d. 5 / 0
    e. 10 > 2 > 0
    f. 15 < 3 * 10
    g. 3 * hola + 2
    h. 5 / “hola”
    i.  * 32
    j. √25
    k. “Tienes” + 23 + “años”
 */

const a = 2>3+2;
const b = 1 + false +3.5;
const c = 4 * true + 2;
const d = 5 / 0;
const e = 10 > 2 > 0;
const f = 10 > 2 > 0;
const hola = 5;
const g = 3 * hola + 2;
const h = 5 / "hola";
const i = "" * 32;
const j = Math.sqrt(25);
const k = "Tienes" + 23 + "años";

console.log("Ejercicio B")
console.log(`A: ${a}`)
console.log(`B: ${b}`)
console.log(`C: ${c}`)
console.log(`D: ${d}`)
console.log(`E: ${e}`)
console.log(`F: ${f}`)
console.log(`G: ${g}`)
console.log(`H: ${h}`)
console.log(`I: ${i}`)
console.log(`J: ${j}`)
console.log(`K: ${k}`) 


//c) Observa el siguiente código y contesta:
//R: Observo que segun el codigo que se me dio, salta un error en la linea 60 porque no esta iniciado la variable nombre
//lo cual es correcto  y al haber ese error no se ejecutar la funcion saludar.
//Para solucionar esto se pone la variable VAR por fuera de la funcion

console.log("Ejercicio C")
var nombre = "Pedro";

function saludar() { 
    alert("Hola" + nombre);    
}

alert("Usuario: " + nombre)
saludar();



