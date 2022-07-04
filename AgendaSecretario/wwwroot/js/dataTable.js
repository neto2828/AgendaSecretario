$(document).ready(function () {
    $('#example').DataTable({
        language: {
            lengthMenu: 'Mostrar _MENU_ registros por página',
            zeroRecords: 'No se encontró nada - lo siento',
            info: 'Mostrando la página _PAGE_ de _PAGES_',
            infoEmpty: 'No hay registros disponibles',
            infoFiltered: 'filtrado de _MAX_ registros totales',
        },
    });
});
