let lock = false;

window.scrollLock = () => {
    let pagePosition = window.scrollY;
    document.body.style.position = 'fixed';
    lock = true;
    document.body.dataset.position = pagePosition;
    document.body.style.top = - pagePosition + 'px';
    document.documentElement.style.scrollBehavior = 'auto';
}

window.scrollUnlock = () => {
    let pagePosition = parseInt(document.body.dataset.position, 10);
    document.body.style.position = '';
    document.body.style.top = '';
    lock = false;
    window.scrollTo({
        top: pagePosition,
        behavior: "auto"
    });
    document.documentElement.style.scrollBehavior = 'smooth';
}

window.scrollToggle = () => {
    if (lock) scrollUnlock();
    else scrollLock();
    console.log('Scroll lock toggled...');
}


