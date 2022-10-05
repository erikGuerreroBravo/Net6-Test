$(document).ready(function () {

    $('#Calle').prop('disabled', false);
    $('#Colonia').prop('disabled', true);
    $('#CodigoPostal').prop('disabled', true);
    $('#NumeroInterior').prop('disabled', true);
    $('#btnGuardar').prop('disabled', true);


    $('#Calle').keyup(function () {
        let data = $(this).val();
        if (data == "") {
            $('#Colonia').prop('disabled', true);
            $('#CodigoPostal').prop('disabled', true);
            $('#NumeroInterior').prop('disabled', true);

            $('#btnGuardar').prop('disabled', true);
        }
        else {
            $('#Colonia').prop('disabled', false);
        }
    });
    $('#Colonia').keyup(function () {
        let data = $(this).val();
        if (data == "") {
            
            $('#CodigoPostal').prop('disabled', true);
            $('#NumeroInterior').prop('disabled', true);

            $('#btnGuardar').prop('disabled', true);
        }
        else {
            $('#CodigoPostal').prop('disabled', false);
        }
    });
    $('#CodigoPostal').keyup(function () {
        let data = $(this).val();
        if (data == "") {
            $('#NumeroInterior').prop('disabled', true);
            $('#btnGuardar').prop('disabled', true);
        }
        else {
            $('#NumeroInterior').prop('disabled', false);
        }
    });
    $('#NumeroInterior').keyup(function () {
        let data = $(this).val();
        if (data == "") {
            
            $('#btnGuardar').prop('disabled', true);
        }
        else {
            $('#btnGuardar').prop('disabled', false);
        }
    });



});