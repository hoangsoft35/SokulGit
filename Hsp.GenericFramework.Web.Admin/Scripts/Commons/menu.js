
$(document).ready(function () {
    // hide all left menu for first run
    hideAllLeftMenu();
    bindEventForTopMenu();
    bindEventForLeftMenu();
    $('#navbar ul li:first-child').addClass("active");
    activeTopAndLoadLeftMenu();
});

function activeTopAndLoadLeftMenu() {
    var parentid = $('#left-menu ul > li.curCol > a[href *="' + window.location.pathname + '"]').parent().parent().parent().data('parent-id');
    $('#navbar ul li a[data-id="' + parentid + '"]').click();
    $('#left-menu ul > li.curCol > a[href *="' + window.location.pathname + '"]').parent().parent().parent().show();
    $('#left-menu ul > li.curCol > a[href *="' + window.location.pathname + '"]').parent().addClass('active');
}

function hideAllLeftMenu() {
   
     $('#left-menu dt, #left-menu dd').hide();
}

function bindEventForTopMenu() {
    $('#left-menu').show();
    $('#navbar ul li').delegate("a", "click", function () {
        $('#navbar ul li').removeClass("active");
        $(this).parent().addClass("active");
        var link = $(this);
        var topMenuId = link.data("id");
        hideAllLeftMenu();
        $('#left-menu dt').filter("[data-parent-id='" + topMenuId + "']").show();
    });

}

function bindEventForLeftMenu() {
    $('#left-menu').delegate("dt", "click", function () {
        
        var section = $(this);
        var isExpand = section.data("is-expand");
        var parentId = section.data("parent-id");
        var expandId = section.data("id");
        

        // get all section if any section is expand set value to false and add event slideUp
        $('#left-menu dt').filter("[data-parent-id='" + parentId + "']").each(function () {
            var sectionNeedCollape = $(this);
            var collapeId = sectionNeedCollape.data("id");
            if (expandId !== collapeId) {
                sectionNeedCollape.next().slideUp(300);
                sectionNeedCollape.attr("is-expand", false);
            }
           
        });
        if (isExpand === false) {
            section.next().slideDown(300);
            section.attr("is-expand", true);
        }


    });
}