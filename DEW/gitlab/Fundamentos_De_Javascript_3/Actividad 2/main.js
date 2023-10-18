/*Defina un código javascript donde muestre todas las propiedades que se han indicado sobre el objeto
Screen. ¿Cuál es mayor height o availHeight? ¿Cuál es la más recomendable utilizar?
 */

const DOM= {
    closed: document.getElementById("closed"),
    document: document.getElementById("document"),
    frames: document.getElementById("frames"),
    history: document.getElementById("history"),
    innerHeight: document.getElementById("innerHeight"),
    innerWidth: document.getElementById("innerWidth"),
    length: document.getElementById("length"),
    location:document.getElementById("location"),
    name:document.getElementById("name"),
    navigator:document.getElementById("navigator"),
    opener:document.getElementById("opener"),
    outerHeight: document.getElementById("outerHeight"),
    pageXOffset:document.getElementById("pageXOffset"),
    Parent: document.getElementById("Parent"),
    Screen: document.getElementById("Screen")
}

const mostrarClosed = () => {
    let closed=window.closed;
    DOM.closed.innerText=closed;
    return closed;
}

const mostrarDocument =()=>{
    let documentt=window.document;
    
    let nodosBody=documentt.children[0].children[1].children;
    [...nodosBody].forEach(nodo=>{ 
        DOM.document.innerText+=nodo.textContent+"|";
    })          
    return documentt;
}

const mostrarframes=()=>{
    let frames=window.frames.clientInformation;
    console.log(frames)
    frames.geolocation.getCurrentPosition(position=>{console.log(position.coords.latitude,position.coords.longitude,DOM.frames.innerText+=`Latitud: ${position.coords.latitude} | Longitud: ${position.coords.longitude}`)},error=>{console.log(error)});
    let longitude=frames.geolocation.getCurrentPosition(position=>{return position.coords.longitude});
    let latitude=frames.geolocation.getCurrentPosition(position=>{return position.coords.longitude});
    return `longitud: ${longitude} | latitud: ${latitude}`;
}

const mostrarHistory=()=>{
    let history = window.history;
    DOM.history.innerText+=history.length;
    return history.length;
}
const mostrarinnerHeight=()=>{
    let innerHeight = window.innerHeight;
    DOM.innerHeight.innerText+=innerHeight.toPrecision(10);
    return innerHeight.toPrecision(10)
}

const mostrarWidth =()=>{
    let width = window.innerWidth;
    DOM.innerWidth.innerText+=width.toPrecision(10)
    return width.toPrecision(10)
}

const longitudFrames = () => {
    let length = window.length;
    DOM.length.innerText+=length;
    return length;
}

const mostrarLocation=()=>{
    let location= window.location;
    DOM.location.innerText+=location.ancestorOrigins.contains("http");
    return location;
}

const mostrarName=()=>{
    let name=window.name;
    DOM.name.innerText+=name="Venta de Prueba";
    return name;
}

const mostrarNavigator=()=>{
    let navigator = window.navigator;
    DOM.navigator.innerText+=`navigator: ${navigator.activeVRDisplays="No esta definido"}, ${navigator.appCodeName},${navigator.webdriver}`;
    return navigator;
}

const mostrarOpener = () => {
    let opener = window.opener;
    opener="Nombre de la ventana"
    DOM.opener.innerHTML+=opener;
    return opener;
}

const  mostrarouterHeight =()=>{
    let outerHeight = window.outerHeight;
    DOM.outerHeight.innerText+=outerHeight.toPrecision(10);
    return outerHeight;
}

const mostrarpageXOffset =()=>{
    let pageXOffset= window.pageXOffset;
    DOM.pageXOffset.innerText+=pageXOffset.toPrecision(10);
    return pageXOffset.toPrecision(10)
}

const mostrarParent=()=>{
    let parent  = window.parent;
    DOM.Parent.innerText+=parent.clientInformation.languages;
    return parent;
}
//Screen
const mostrarScreen =()=>{
    let Screen= window.Screen;
    DOM.Screen.innerText+=Screen.name;
    return Screen;
}
const ejecutarTodo = ()=>{
    mostrarClosed();
    mostrarDocument();
    mostrarframes();
    mostrarHistory();
    mostrarinnerHeight();
    mostrarWidth();
    longitudFrames();
    mostrarLocation();   
    mostrarName(); 
    mostrarNavigator();
    mostrarOpener();
    mostrarouterHeight();
    mostrarpageXOffset();
    mostrarParent();
    mostrarScreen();
}   
ejecutarTodo();