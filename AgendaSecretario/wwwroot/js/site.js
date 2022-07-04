function add() {
    const selectElement = document.querySelector('#selectTab2Gestion');
    var elements = document.querySelectorAll(".entrada-usuario");
    var valor = document.getElementById('url').value;

selectElement.addEventListener('change', (event) => {
    const seleccionado = event.target.value;

    if (seleccionado === 'carlosmunizrodriguez1') {
        for (var i = 0; i < elements.length; i++) {
            elements[i].value = valor.substr(53, 500);
        }
    }
    else if (seleccionado === 'HIDALGO.SEDAGRO') {
        for (var i = 0; i < elements.length; i++) {
            elements[i].value = valor.substr(47, 500);
        }
    }


});
}

/*

function add() {
    var elements = document.querySelectorAll(".entrada-usuario");
    var valor = document.getElementById('url').value;
    
    for (var i = 0; i < elements.length; i++) {
        elements[i].value = valor.substr(1,2);


    }

}

*/

