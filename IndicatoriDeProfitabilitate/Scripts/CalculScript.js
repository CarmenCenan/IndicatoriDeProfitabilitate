function calcul() {
   var val1= parseFloat($('#val1').val());
   var val2= parseFloat($('#val2').val());

    var result = val1/val2;

    $('#result').val(result);
}