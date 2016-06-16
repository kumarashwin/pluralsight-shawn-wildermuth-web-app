// site.js

(function () {

    var ele = $("#username");
    ele.text("Ash");

    //var main = $("#main");
    //main.on("mouseover", function () { main.css("background-color", "#888"); });
    //main.on("mouseout", function () { main.css("background-color", ""); });

    /*var menuItems = $("ul.menu li a");
    menuItems.on("click", function ()
    {
        alert($(this).text());
    });*/

    var $sidebarAndWrapper = $("#sidebar, #wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");

        if ($sidebarAndWrapper.hasClass("hide-sidebar"))
        {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
        else
        {
            $icon.removeClass("fa-angle-right");
            $icon.addClass("fa-angle-left");
        }

    });
    
})();