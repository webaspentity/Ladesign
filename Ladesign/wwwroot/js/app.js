'use strict';

//let lock = false;
let bodyDisabled = false;
let dotnetHeader;

//window.scrollLock = () => {
//    let pagePosition = window.scrollY;
//    document.body.style.position = 'fixed';
//    lock = true;
//    document.body.dataset.position = pagePosition;
//    document.body.style.top = - pagePosition + 'px';
//    document.documentElement.style.scrollBehavior = 'auto';
//}

//window.scrollUnlock = () => {
//    let pagePosition = parseInt(document.body.dataset.position, 10);
//    document.body.style.position = '';
//    document.body.style.top = '';
//    lock = false;
//    window.scrollTo({
//        top: pagePosition,
//        behavior: "auto"
//    });
//    document.documentElement.style.scrollBehavior = 'smooth';
//}



//window.scrollToggle = () => {
//    if (lock) scrollUnlock();
//    else scrollLock();
//}

window.getEditableContent = (element) => {
    return element.textContent;
}

//===========================================================

window.preventScroll = (e) => {
    e.preventDefault();
    e.stopPropagation();
    return false;
}

window.disableBody = () => {
    document.body.addEventListener('wheel', preventScroll, { passive: false });
    bodyDisabled = true;
}

window.enableBody = () => {
    document.body.removeEventListener('wheel', preventScroll, { passive: false });
    bodyDisabled = false;
}

//================================================================

window.openModal = (element) => {
    element.showModal();
    /*scrollLock();*/
    disableBody();
}

window.closeModal = (element) => {
    element.close();
    /*scrollUnlock();*/
    enableBody();
}


window.runOnScroll = () => {
    if (window.location.pathname === "/") {
        const header = document.getElementById('header');
        if (!header.classList.contains('fixed') && pageYOffset >= header.clientHeight) {
            header.classList.add('fixed');
        } else if (pageYOffset < header.clientHeight && header.classList.contains('fixed')) {
            header.classList.remove('fixed');
        }
    }
}

window.debounce = (func, ms, now) => {

    let onLast

    return function () {

        const context = this
        const args = arguments

        const onFirst = now && !onLast

        clearTimeout(onLast)

        onLast = setTimeout(() => {

            onLast = null
            if (!now) func.apply(context, args)

        }, ms)

        if (onFirst) func.apply(context, args)

    }
};

window.setHeaderNoFixed = () => {
    const header = document.getElementById('header');
    if (header.classList.contains('fixed')) header.classList.remove('fixed');
}

window.setHeaderFixed = () => {
    const header = document.getElementById('header');
    if (!header.classList.contains('fixed')) header.classList.add('fixed');
}

window.toggleBodyOverflow = () => {
    if (document.body.style.overflowY === 'hidden') document.body.style.overflowY = 'auto';
    else document.body.style.overflowY = 'hidden';
}

window.addEventListener('scroll', runOnScroll);

window.toggleMenu = () => {
    dotnetHeader.invokeMethodAsync("ToggleMenu");
    console.log('ToggleMenu from JS...');
    dotnetHeader.invokeMethodAsync("Refresh");
    console.log('Refresh from JS...');
}

window.runOnResize = () => {
    if (document.body.clientWidth > 768) {
        if (bodyDisabled)  {
            enableBody();
            toggleMenu();
            console.log('Body disabled (runOnResize)? ' + bodyDisabled);
        }
    }
}

window.addEventListener('resize', debounce(runOnResize, 100));

window.setHeader = (dotnetObj) => {
    dotnetHeader = dotnetObj;
}