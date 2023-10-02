//a) ¿Qué hace el siguiente código? ¿para que se utiliza typeof?
// alert(typeof())
//R: Sirven para saber el tipo de dato es un variable

const cadena = "cadena";
console.error("Ejercicio A")
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

console.error("Ejercicio B")
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

console.error("Ejercicio C")
var nombre = "Pedro";

function saludar() { 
    alert("Hola" + nombre);    
}

//alert("Usuario: " + nombre)
//saludar();

//d) [Trate de resolver antes de ejecutar el código, luego puede comprobarlo] ¿Qué mostrará la segunda
//ventana emergente?
//R: Sera Juan.
console.error("Ejercicio D")

var nombre = "Juan";

function saludar() { 
    var nombre = "Pedro";
    alert("Hola " + nombre);    
}

//saludar();
//alert("Usuario: " + nombre)

//e) ¿Qué generan los siguientes códigos?

<<<<<<< HEAD
//a R: me devuelve una cadena "true"
var resultado = true
resultado.toString()
console.error("Ejercicio E")
console.log(typeof(resultado.toString()))
 
=======
//a R: 
var resultado = "1";
parseInt(resultado);
console.log(typeof(resultado))
console.log(typeof(resultado))
>>>>>>> 5e5482f8ed6b638e6ca4b32fc518c2cea8a362fc

//b R: Devuelve la union de 'false' con la cadena "o true", lo cual sale un tipo string
var llueve = false;
llueve+= " o true?";
console.log(llueve)


//f) ¿Qué valor producirán las siguientes expresiones?

/**
 *  a. parseInt("15");
    b. parseInt("15.5")
    c. parseInt(15.5)
    d. parseInt("true")
    e. parseInt(true)
    f. parseInt("Pedro")
    g. parseInt(15 + "Pedro")
    h. parseFloat("15.5")
    i. parseFloat(15.5) 
 */

    let f_a= parseInt("15")
    let f_b= parseInt("15.5")
    let f_c= parseInt(15.5)
    let f_d= parseInt("true")
    let f_e= parseInt(true)
    let f_f= parseInt("Pedro")
    let f_g= parseInt(15 + "Pedro")
    let f_h= parseFloat("15.5")
    let f_i= parseFloat(15.5)

    console.error("EJERCICIO F")
    console.log(`A: ${f_a}: "15"`)
    console.log(`B: ${f_b}: "15.5"`)
    console.log(`C: ${f_c}: 15.int`)
    console.log(`D: ${f_d}: true.string`)
    console.log(`E: ${f_e}: true.bolean`)
    console.log(`F: ${f_f}: "Pedro"`)
    console.log(`G: ${f_g} -> muy interesante que tome solo el numero y no "Pedro".`)
    console.log(`H: ${f_h}: "15.5"`)
    console.log(`I: ${f_i}: 15.int`)

    /*EJERCICIO 3 */
    console.error("EJERCICIO 3")

    var n=7; 
    alert("n vale " + (++n));
    