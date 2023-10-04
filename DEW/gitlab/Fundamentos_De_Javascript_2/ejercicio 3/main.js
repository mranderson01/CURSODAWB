const DOM = {
    form: document.getElementById("form"),
    valor: document.getElementById("obtValor"),
    btnCalcular: document.getElementById("btnCalcular"),
    error: document.getElementById("error"),
    contResultado: document.getElementById("contResultado")
}

function fibonacci(n) {
    if (n <= 0) {
      return 0;
    } else if (n === 1) {
      return 1;
    } else {
      return fibonacci(n - 1) + fibonacci(n - 2);
    }
  }
  
  // Ejemplo de uso:
  var n = 10;
  var resultado = fibonacci(n);
  console.log("El término " + n + " de la secuencia de Fibonacci es: " + resultado);
  
