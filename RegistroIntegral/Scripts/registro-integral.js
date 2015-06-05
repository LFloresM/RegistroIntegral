//var pafVM = null;
//var pafViewModel = function () {
//    pafVM = this;

//    pafVM.withMenu = ko.observable(true);
//    pafVM.withMenuOverlay = ko.observable(false);
//    pafVM.withMenuIconsOnly = ko.observable(false);
//    pafVM.selectMenuItemNumber = ko.observable(0);
//    pafVM.withRightSlide = ko.observable(false);
//    pafVM.mainContainerType = ko.observable('dashboard');

//    pafVM.lastCall_setActiveItem = 0;

//}


//function inboxPaf() {
//    $("#mainContainer").load('/inbox/pafInbox');
//    //$('body').css('background', 'none');
//    //pafVM.breadCrumbs([{ url: '/', name: 'Home' }, { url: '/inboxPaf', name: '/ PAF Center' }]);
//    //if ((pafVM.viewport() == 'xxs' || pafVM.viewport() == 'xs') && !pafVM.withMenuIconsOnly()) pafVM.vMenuOutByOverlay();
//    //return true;
//}


//function setActiveItem(target) {

//    var now = new Date();
//    var lastCallTime = pafVM.lastCall_setActiveItem;
//    if (lastCallTime != null && ((now - pafVM.lastCall_setActiveItem) / 2000) < 1) return;
//    pafVM.lastCall_setActiveItem = now;

//    pafVM.selectMenuItemNumber(target);
//    return true;
//}