$(document).ready(function () {
    menuItemTypeChange();
    
    $('#btnAdd').on('click', function () {
        var selectedNode = $('#tree').treeview('getSelected');
        if (selectedNode && selectedNode.length)
        {
            selectedNode = selectedNode[0];
            var selectedMenuItemType = $("#menu-item-type").val();
            window.location.href = '/MenuItem/AddEditMenuItem?parentId=' + selectedNode.Id + '&menuItemTypeId=' + selectedMenuItemType ;

            

        }       
    });

  

});
function getMenuItemId() {
    var selectedNode = $('#tree').treeview('getSelected');
    if (selectedNode && selectedNode.length) {
        selectedNode = selectedNode[0];
        return selectedNode.Id;
    } else {
        return "";
    }
}
var _menuItems = [];

function mapMenuItemsData() {
    var roots = _.filter(_menuItems, function (t) { return t.IsRoot; });  
    roots = mapMenuItemsDataLevel2(roots);
    return roots;
}

function mapMenuItemsDataLevel2(menuItems) {
    _.each(menuItems, function (t) {
        var childs = _.filter(_menuItems, function (t1) { return t1.ParentId == t.Id && t1.Id != t1.ParentId; });
        t.nodes = [];
        t.Level = 1;
        t.text = t.Label;
        if (childs.length > 0) {
            childs = _.map(childs, function (t3) { t3.Level = 3; t3.text = t3.Label; state: { disabled: true; checked: true }; return t3; });
            t.nodes = childs;
            mapMenuItemsDataLevel3(childs);
        }
         else {
            delete t.nodes;
        }
    });
    return menuItems;
}

function mapMenuItemsDataLevel3(menuItems) {
    _.each(menuItems, function (t) {
        var childs = _.filter(_menuItems, function (t1) { return t1.ParentId == t.Id && t1.Id != t1.ParentId; });
        t.nodes = [];
        t.Level = 2;
        t.text = t.Label;
        if (childs.length > 0) {
            childs = _.map(childs, function(t3) {
                t3.Level = 3;
                t3.text = t3.Label;
                state: {
                    disabled: true;
                    checked : true;
                };
                return t3;
            });
            t.nodes = childs;
        } else {
            delete t.nodes;
        }
    });
    return menuItems;
}

function menuItemTypeChange() {
    var selected = $("#menu-item-type").val();
    $.ajax({
        url: "/MenuItem/GetMenuByMenuType?menuItemTypeId=" + selected,
        type: 'GET',
        success: function (data) {
            _menuItems = data;
            $('#tree').treeview({ data: mapMenuItemsData(), showIcon: false });
            $('#tree').on('nodeSelected', function (event, data) {
                console.log(data);
                if (data.Level == 3) {
                    $('#btnAdd').addClass('disabled');
                    $('#btnAdd').prop('disabled',true);
                }
                else {
                    $('#btnAdd').removeClass('disabled');
                    $('#btnAdd').prop('disabled', false);
                }
            });
        },
        error: function (err) {
            console.log(err);
        }
    });
}


function getContentMultiLanguage() {

    var data = $('#tab-content-multi-language').find('input[name^="label-lang"]');
    var result = [];
    if (data != undefined && data.length > 0) {
        $.each(data, function (index, t) {
            var transtation = { LanguageId: $(t).data('lang'), Label: $(t).val() }
            result.push(transtation);
        });

    }

    return result;
}


