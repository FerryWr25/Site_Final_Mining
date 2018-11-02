(function ($) {
    // USE STRICT
    "use strict";

    $(".form-radio .radio-item").click(function(){
        //Spot switcher:
        $(this).parent().find(".radio-item").removeClass("active");
        $(this).addClass("active");
    });
  
    $('#jenkel').parent().append('<ul class="list-item" id="newjenkel" name="jenkel"></ul>');
    $('#jenkel option').each(function(){
        $('#newjenkel').append('<li value="' + $(this).val() + '">'+$(this).text()+'</li>');
    });
    $('#jenkel').remove();
    $('#newjenkel').attr('id', 'jenkel');
    $('#jenkel li').first().addClass('init');
    $("#jenkel").on("click", ".init", function() {
        $(this).closest("#jenkel").children('li:not(.init)').toggle();
    });

    
    $('#instansi').parent().append('<ul class="list-item" id="newinstansi" name="instansi"></ul>');
    $('#instansi option').each(function(){
        $('#newinstansi').append('<li value="' + $(this).val() + '">'+$(this).text()+'</li>');
    });

    $('#instansi').remove();
    $('#newinstansi').attr('id', 'instansi');
    $('#instansi li').first().addClass('init');
    $("#instansi").on("click", ".init", function() {
        $(this).closest("#instansi").children('li:not(.init)').toggle();
    });

     $('#agama').parent().append('<ul class="list-item" id="newagama" name="agama"></ul>');
    $('#agama option').each(function(){
        $('#newagama').append('<li value="' + $(this).val() + '">'+$(this).text()+'</li>');
    });
    $('#agama').remove();
    $('#newagama').attr('id', 'agama');
    $('#agama li').first().addClass('init');
    $("#agama").on("click", ".init", function() {
        $(this).closest("#agama").children('li:not(.init)').toggle();
    });


    var allOptions = $("#jenkel").children('li:not(.init)');
    $("#jenkel").on("click", "li:not(.init)", function() {
        allOptions.removeClass('selected');
        $(this).addClass('selected');
        $("#jenkel").children('.init').html($(this).html());
        allOptions.toggle();
    });

    var instansiOptions = $("#instansi").children('li:not(.init)');
    $("#instansi").on("click", "li:not(.init)", function() {
        instansiOptions.removeClass('selected');
        $(this).addClass('selected');
        $("#instansi").children('.init').html($(this).html());
        instansiOptions.toggle();
    });

    var agamaOptions = $("#agama").children('li:not(.init)');
    $("#agama").on("click", "li:not(.init)", function() {
        agamaOptions.removeClass('selected');
        $(this).addClass('selected');
        $("#agama").children('.init').html($(this).html());
        agamaOptions.toggle();
    });

})(jQuery);