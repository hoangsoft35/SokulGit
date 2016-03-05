$(document).ready(function () {
    menuItemTypeChange();
    $('#btnAdd').on('click', function () {
        var selectedNode = $('#tree').treeview('getSelected');
        if (!selectedNode)
            return false;

        selectedNode = selectedNode[0];
        var selectedMenuItemType = $("#menu-item-type").val();
        $("input[name=MenuItemTypeId]").val(selectedMenuItemType);
        $("input[name=ParentId]").val(selectedNode.Id);        
    });

    $("input[type='checkbox'], input[type='radio']").bootstrapSwitch();
});

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
            childs = _.map(childs, function (t3) { t3.Level = 3; t3.text = t3.Label; state: { disabled: true; checked : true }; return t3; });
            t.nodes = childs;
        }
    });
    return menuItems;
}

function menuItemTypeChange() {
    var selected = $("#menu-item-type").val();
    $.ajax({
        url: "/domain/MenuItem/GetMenuByMenuType?menuItemTypeId=" + selected,
        type: 'GET',
        success: function (data) {
            _menuItems = data;
            $('#tree').treeview({ data: mapMenuItemsData() });
            $('#tree').on('nodeSelected', function (event, data) {
                console.log(data);
                if (data.Level == 3) {
                    $('#btnAdd').addClass('disabled');
                }
                else {
                    $('#btnAdd').removeClass('disabled');
                }
            });
        },
        error: function (err) {
            console.log(err);
        }
    });
}

function save() {
    var formData = $('form').serializeJSON();
    $.ajax({
        url: "/domain/MenuItem/GetMenuByMenuType?menuItemTypeId=" + selected,
        type: 'POST',
        data: JSON.stringify(formData),
        success: function (data) {
            console.log(data);
        },
        error: function (err) {
            console.log(err);
        }
    });
}