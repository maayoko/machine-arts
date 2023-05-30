$('.grid-item img').click(function () {
    var naziv = $(this).data('naziv');
    var cijena = $(this).data('cijena');
    var opis = $(this).data('opis');
    opis = opis.split("|").join("<br/>");
    var src = $(this).attr('src');

    $('#productImage').attr('src', src);
    $('#productName').text(naziv);
    $('#productPrice').text(cijena);
    $('#productSpecs').html(opis);

    $('#productOverlay').show();
});



$('#productOverlay').click(function () {
    $(this).hide();
});


$('.overlay-content').click(function (event) {
    event.stopPropagation();
});
