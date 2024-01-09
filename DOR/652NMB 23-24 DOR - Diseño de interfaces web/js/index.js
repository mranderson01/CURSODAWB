const DOM = {
    body: null,
    main:null,
    header_nav: null,
    header_a:null,
    //main
    h1: null,
    card:null,
    card_parrafo:null,
    btnCambiar: null,
    //footer
    footer: null
}

/*
   modo noche:
    .colorNoche1 {color: #140f0d;} Body
    .colorNoche2 {color: #0e365c;} Parragfo
    .colorNoche3 {color: #0876ba;} h1Noche
    .colorNoche4 {color: #08c1ff;} 
    .colorNoche5 {color: #0ffff8;} 

   Modo Dia:
    .colorDia1 {color: #00aeff;}
    .colorDia2 {color: #b49bff;}
    .colorDia3 {color: #ffa0ff;}
    .colorDia4 {color: #ffccea;}
    .colorDia5 {color: #fff5cb;}
*/

document.addEventListener('DOMContentLoaded', function() {
    //poner los colores por defecto modo dia
    DOM.body = document.querySelector("body");
    DOM.main = document.querySelector("main"); 
    DOM.header_nav = document.querySelector("header>nav");
    DOM.header_a = document.querySelectorAll("nav a");
    DOM.h1 = document.querySelectorAll("main h1")
    //FUNCIONES
    modoDia();

});

const modoDia = () => { 
    DOM.main.setAttribute("class","backgroundDia");
    DOM.header_nav.setAttribute("class","navbar bg-primary");
    DOM.header_a.forEach(a => {
        if (a.id!="btnCambiar") {
            a.setAttribute("class","nav_colorTexto");
        } 
    }); 
}

const cambiarModo = (e) => {
    e.preventDefault();
 
}
