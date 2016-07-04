$(document).ready(function() {
    
    

    //$("#frmAddNewMenuItem").validate({
    //    rules: {
    //        ActionName: {
    //            required: true,
    //            maxlength: 100
    //        },
    //        ControllerName: {
    //            required: true,
    //            maxlength: 100
    //        },
    //        SectionParameter: {
    //            required: true,
    //            number: true
    //        },
    //        Order: {
    //            required: true,
    //            number: true,
    //            min: 1
    //        },
    //        Name: {
    //            required: true,
    //            maxlength: 100
    //        }
    //    },
    //    messages: {
    //        ActionName: {
    //            required: "Please enter a ActionName",
    //            maxlength: "Please enter no more than 100 characters"
    //        },
    //        ControllerName: {
    //            required: "Please enter a ControllerName",
    //            maxlength: "Please enter no more than 100 characters"
    //        },
    //        SectionParameter: {
    //            required: "Please provide a SectionParameter",
    //            number: "Please enter a valid number"
    //        },
    //        Order: {
    //            required: "Please provide a Order",
    //            number: "Please enter a valid number",
    //            min: "Please enter a value greater than or equal to 0"
    //        },
    //        Name: {
    //            required: "Please enter a Name",
    //            maxlength: "Please enter no more than 100 characters"
    //        }
    //    },
    //    submitHandler: function (form) {
    //        save();
    //    }
    //});
    $("input[type='checkbox'], input[type='radio']").bootstrapSwitch();
});

function save() {
    var formData = $('form').serializeJSON();
    var menuItemCreateViewModels = {
        MenuItemModel: {
            MenuItemTypeId: formData.MenuItemTypeId,
            IsRoot: formData.IsRoot,
            IsTitle: formData.IsTitle,
            IsLink: formData.IsLink,
            ParentId: formData.ParentId,
            ControllerName: formData.ControllerName,
            ActionName: formData.ActionName,
            SectionParameter: formData.SectionParameter,
            Order: formData.Order
        },
        MenuItemTranslationModels: getContentMultiLanguage()
    };
    $.ajax({
        url: "/MenuItem/CreateMenuItem",
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
