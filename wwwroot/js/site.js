// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function confirm_delete() {
    return confirm("Bạn muốn xóa bản ghi này ?");
}

$(document).ready(function() {
    function DefaultGUI() {
        $("#find_type").show();
        $("#add_type").hide();
        $("#nav_find_type").addClass("active");
        $("#nav_add_type").removeClass("active");
    }

    function ActiveNav() {
        switch ($(location).attr('pathname')) {
            case '/RevenueExpenditure':
                $('#RevenueExpenditure').addClass("active");
                break;
            case '/RevenueExpenditureType':
                $('#RevenueExpenditureType').addClass("active");
                break;
            case '/Fund':
                $('#Fund').addClass("active");
                break;
            case '/Statistics':
                $('#Statistics').addClass("active");
                break;
        }
    }
    DefaultGUI();
    ActiveNav();

    $("#nav_find_type").click(DefaultGUI);
    $("#nav_add_type").click(function() {
        $("#add_type").show();
        $("#find_type").hide();
        $("#nav_add_type").addClass("active");
        $("#nav_find_type").removeClass("active");
    });
});