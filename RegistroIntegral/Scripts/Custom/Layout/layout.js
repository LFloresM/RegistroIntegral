
var loVM = null;
var layoutViewModel = function () {
    loVM = this;

    evalViewport(); // This is contained in the master page _layout to hold a .js version of bootraps's sizing in use. is set the javascript var 'viewport'
    loVM.viewport = ko.observable(viewport); // adjusts later using window.onresize
    loVM.jobListSection = ko.observable('group');

    loVM.test = ko.observable("test");
    loVM.contextMenuType = ko.observable('contextMain');
    loVM.breadCrumbs = ko.observableArray([]);
    loVM.menuItem = ko.observable('dashboard')

    loVM.withMenu = ko.observable(true);
    loVM.withMenuOverlay = ko.observable(false);
    loVM.withMenuIconsOnly = ko.observable(false);
    loVM.selectMenuItemNumber = ko.observable(0);
    loVM.withRightSlide = ko.observable(false);
    loVM.currentUser = ko.observable({})

    loVM.lastCall_setActiveItem = 0;

    loVM.mainContainerType = ko.observable('dashboard');

    loVM.newRequest = ko.observable();

    loVM.vMenuToggle = function () {
        if (loVM.withMenuIconsOnly()) {
            loVM.vMenuIn();
            return;
        }
        if (loVM.withMenu()) loVM.vMenuOut();
        else loVM.vMenuIn();
    }
    loVM.vMenuIn = function () {
        if (loVM.viewport() == 'xxs' || loVM.viewport() == 'xs') { loVM.vMenuInByOverlay(); return; }
        loVM.withMenuOverlay(false);
        loVM.withMenuIconsOnly(false);
        loVM.withMenu(true);
    }
    loVM.vMenuOut = function () {
        if (loVM.viewport() == 'xxs' || loVM.viewport() == 'xs') { loVM.vMenuOutByOverlay(); return; }
        loVM.withMenuOverlay(false);
        loVM.withMenuIconsOnly(false);
        loVM.withMenu(false);
    }

    loVM.vMenuToggleByOverlay = function () {
        if (loVM.withMenuOverlay()) loVM.vMenuOutByOverlay();
        else loVM.vMenuInByOverlay();
    }
    loVM.vMenuInByOverlay = function () {
        loVM.withMenuOverlay(true);
        loVM.withMenuIconsOnly(false);
        loVM.withMenu(true);
    }
    loVM.vMenuOutByOverlay = function () {
        loVM.withMenuOverlay(false);
        loVM.withMenuIconsOnly(false);
        loVM.withMenu(false);
    }

    loVM.iconsOnlyToggle = function () {
        if (loVM.withMenuIconsOnly()) {
            loVM.iconsOnlyOut();
        }
        else {
            loVM.iconsOnlyIn(); ''
            $('#inboxMenuCollapse').removeClass('in');
        }
    }
    loVM.iconsOnlyIn = function () {
        loVM.withMenuOverlay(false);
        loVM.withMenuIconsOnly(true);
        loVM.withMenu(true);
        $('.menuTooltip').tooltip('enable');
    }
    loVM.iconsOnlyOut = function () {
        loVM.withMenuOverlay(false);
        loVM.withMenuIconsOnly(false);
        loVM.withMenu(true);
        $('.menuTooltip').tooltip('disable');
    }

    loVM.rightSlideToggle = function () {
        if (loVM.withRightSlide()) loVM.rightSlideOut();
        else loVM.rightSlideIn();
    }

    loVM.rightSlideIn = function () {
        if (loVM.viewport() != 'xxs' && loVM.viewport() != 'xs') { return; }
        loVM.withRightSlide(true);
    }
    loVM.rightSlideOut = function () {
        loVM.withRightSlide(false);
    }

    loVM.togglePlus = function () {
        $(event.target).toggleClass('fa-plus-square-o fa-minus-square-o');
    }



    // this givs us the ability to post from an mvc module
    $("a[data-form-method='post']").click(function (event) {
        event.preventDefault();
        var element = $(this);
        var action = element.attr("href");
        element.closest("form").each(function () {
            var form = $(this);
            form.attr("action", action);
            form.submit();
        });
    });

    loVM.test = function () {
        debugger
    }

}

function setActiveItem(target) {

    var now = new Date();
    var lastCallTime = loVM.lastCall_setActiveItem;
    if (lastCallTime != null && ((now - loVM.lastCall_setActiveItem) / 2000) < 1) return;
    loVM.lastCall_setActiveItem = now;

    loVM.selectMenuItemNumber(target);
    return true;
}

window.onresize = function () {
    // the core variable 'viewport' is contained in the _Layout.cshtml master page.
    // but the onresize event must in a file that can pass to the ViewModel
    // this code updates the observable so that dependent layout templates will upate
    evalViewport();
    loVM.viewport(viewport); // Will set the observable with one of these text values: xs, sm, md, lg

    if (loVM.viewport() != 'xxs' && loVM.viewport() != 'xs') {
        loVM.vMenuIn();
    }
    if (loVM.viewport() == 'xxs' || loVM.viewport() == 'xs') {
        loVM.vMenuOut();
    }
    if (loVM.viewport() != 'xxs' && loVM.viewport() != 'xs') {
        $('[data-toggle=tooltip]').tooltip('enable'); //Enable tooltips
    }
    if ((loVM.viewport() == 'xxs' || loVM.viewport() == 'xs')) {
        $('[data-toggle=tooltip]').tooltip('disable'); // Disable tooltips

    }


}




var viewport = null;
function evalViewport() {

    viewport = $(".viewport:visible").html(); // find the visible span based on native bootstrap classes
    $("#viewport").html(viewport);
    $("#jqWidth").html($(window).width());
    return;
}

function dashboard() {
    $("#mainContainer").load('/home/dashboard');
    $('body').css('background', 'url("/content/images/background.png") #ffffff;');
    loVM.breadCrumbs([{ url: '/', name: 'Dashboard' }]);
    if ((loVM.viewport() == 'xxs' || loVM.viewport() == 'xs') && !loVM.withMenuIconsOnly()) loVM.vMenuOutByOverlay();
    return true;
}


function inboxMain(searchParam) {
    if (searchParam == null) {
        searchParam = "OnHold=Include";
    }
    else if (searchParam != "OnHold") {
        searchParam = "type=" + searchParam;
        searchParam = searchParam + " OnHold=Include";
    }
    else {
        searchParam = "OnHold=ShowOnly";
        searchParam = searchParam + " OnHold=Include";
    }
    $("#mainContainer").load('/inbox/maininbox?filterDesc=' + encodeURI(searchParam));
    $('body').css('background', 'none');
    loVM.breadCrumbs([{ url: '/', name: 'Home' }, { url: '/inbox', name: '/ Inbox' }]);
    if ((loVM.viewport() == 'xxs' || loVM.viewport() == 'xs') && !loVM.withMenuIconsOnly()) loVM.vMenuOutByOverlay();
    return true;
}

function inboxPaf() {
    $("#mainContainer").load('/Profesor/Index');
    $('body').css('background', 'none');
    loVM.breadCrumbs([{ url: '/', name: 'Home' }, { url: '/inboxPaf', name: '/ PAF Center' }]);
    if ((loVM.viewport() == 'xxs' || loVM.viewport() == 'xs') && !loVM.withMenuIconsOnly()) loVM.vMenuOutByOverlay();
    return true;
}


