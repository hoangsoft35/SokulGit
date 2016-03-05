$(document).ready(function () {
    //Dropdown list on nav



    $(".dropdown-menu li a").click(function () {
        var selText = $(this).text();
        var selVal = $(this).data('val');
         // set selected all item to false
        $(".dropdown-menu li a").parents().find('.dropdown-menu li').data('selected', 'False');
        // set current item was select to true
        $(this).data('selected', "True");

        var parent = $(this).parents().find('.dropdown-toggle');
        parent.data('val', selVal);
        parent.html(selText + '<span class="caret"></span>');
    });
    
});   