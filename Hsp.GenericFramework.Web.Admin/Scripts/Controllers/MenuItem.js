//$(function () {
//    $('.treeview li:has(ul)').find(' > span.icon').removeClass('glyphicon-minus');
//    $('.treeview li:has(ul)').find(' > span.icon').addClass('glyphicon-plus');
//    //$('.treeview li.parent_li > span').on('click', function (e) {
//    //    var children = $(this).parent('li.parent_li').find(' > ul > li');
//    //    if (children.is(":visible")) {
//    //        children.hide('fast');
//    //        $(this).attr('title', 'Expand this branch').find(' > i').addClass('icon-plus-sign').removeClass('icon-minus-sign');
//    //    } else {
//    //        children.show('fast');
//    //        $(this).attr('title', 'Collapse this branch').find(' > i').addClass('icon-minus-sign').removeClass('icon-plus-sign');
//    //    }
//    //    e.stopPropagation();
//    //});
//});


$(document).ready(function () {
    menuItemTypeChange();
    
    $('#btnAdd').on('click', function () {
        var selectedNode = $('#tree').treeview('getSelected');
        if (selectedNode && selectedNode.length)
        {
            selectedNode = selectedNode[0];
            var selectedMenuItemType = $("#menu-item-type").val();
            $("input[name=MenuItemTypeId]").val(selectedMenuItemType);
            $("input[name=ParentId]").val(selectedNode.Id);
        }       
    });

    $("input[type='checkbox'], input[type='radio']").bootstrapSwitch();

    $("#frmAddNewMenuItem").validate({
        rules: {            
            ActionName: {
                required: true,
                maxlength: 100
            },
            ControllerName: {
                required: true,
                maxlength: 100
            },
            SectionParameter: {
                required: true,
                number: true
            },
            Order: {
                required: true,
                number: true,
                min: 1
            },
            Name: {
                required: true,
                maxlength: 100
            }
        },
        messages: {            
            ActionName: {
                required: "Please enter a ActionName",
                maxlength: "Please enter no more than 100 characters"
            },
            ControllerName: {
                required: "Please enter a ControllerName",
                maxlength: "Please enter no more than 100 characters"
            },
            SectionParameter: {
                required: "Please provide a SectionParameter",
                number: "Please enter a valid number"
            },
            Order: {
                required: "Please provide a Order",
                number: "Please enter a valid number",
                min: "Please enter a value greater than or equal to 0"
            },
            Name: {
                required: "Please enter a Name",
                maxlength: "Please enter no more than 100 characters"
            }
        },
        submitHandler: function (form) {            
            save();
        }
    });
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
    var menuItemCreateViewModels = {
        MenuItemCreate: {        
            MenuItemTypeId:formData.MenuItemTypeId,
            IsRoot:formData.IsRoot,
            IsTitle:formData.IsTitle,
            IsLink:formData.IsLink,
            ParentId:formData.ParentId,
            ControllerName:formData.ControllerName,
            ActionName:formData.ActionName,
            SectionParameter:formData.SectionParameter,
            Order:formData.Order
        },
        MenuItemTranslationCreate: {
            Label: formData.Name
        }
    };
    $.ajax({
        url: "/domain/MenuItem/CreateMenuItem",
        type: 'POST',
        data: menuItemCreateViewModels,
        success: function (data) {
            $('#addNewModal').modal('toggle');
            if (data.Code == 0) {                
                alertify.success('Save data success');
            }
            else {
                alertify.error('Failed to save data');
            }
        },
        error: function (err) {
            alertify.error('Failed to save data');
            console.log(err);
        }
    });
}



function addNode() {
    var tree = $('#tree').treeview('getTreeData');
    var node = {
        "Id": "fd76dc8c-79b1-4975-8525-d63d761f5422", "IsRoot": false, "IsActive": true,
        "ParentId": "fd76dc8c-79b1-4975-8525-d63d761f54ae", "Label": "Users2", "IsTitle": true, "IsLink": false,
        "ControllerName": "NULL", "ActionName": "NULL", "SectionParameter": 1, "Order": 7, "Level": 3, "text": "Users2", "nodes": [],
        "nodeId": 16, "parentId": 7, "selectable": true, "state": {
            "checked": false, "disabled": false, "expanded": false, "selected": false
        }
    };

    var parent = _.find(tree, { Id: "fd76dc8c-79b1-4975-8525-d63d761f54ae" });
    parent.nodes.push(node);
    $('#tree').treeview('expandNode', parent, { ignoreChildren: false, silent: false });
    console.log(tree);
}