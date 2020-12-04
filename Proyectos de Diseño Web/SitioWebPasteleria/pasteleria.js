// JavaScript source code

var imagenes = [];
    var IndiceImagenes = 0;
    imagenes[0] = "images/0.jpg";
    imagenes[1] = "images/1.jpg";
    imagenes[2] = "images/2.jpg";

const imagen = document.getElementById("imagen");

setInterval(function () {
    imagen.src = imagenes[IndiceImagenes];
    //alert(imagen);
    if (IndiceImagenes < 2) {
        IndiceImagenes++;
    }
    else {
        IndiceImagenes = 0;
    }

}, 3000);