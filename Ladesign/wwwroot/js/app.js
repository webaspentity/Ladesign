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
}

window.getEditableContent = (element) => {
    return element.textContent;
}

window.openModal = (element) => {
    element.showModal();
}

window.closeModal = (element) => {
    element.close();
}

window.runOnScroll = () => {
    if (window.location.pathname === "/") {
        console.log('Location: ' + window.location.pathname);
        const header = document.querySelector('.header');
        if (pageYOffset >= header.clientHeight) {
            if (!header.classList.contains('fixed')) header.classList.add('fixed');
        } else {
            if (header.classList.contains('fixed')) header.classList.remove('fixed');
        }
    }
}

window.debounce = (func, ms, now) => { // объявляем функцию debounce

    let onLast // переменная отвечает за вызов функции func после того, как прошло время ожидания ms от последнего события движения курсора

    return function () { // эта функция запускается при каждом событии движения курсора

        const context = this // запоминаем передаваемую функцию func
        const args = arguments // запоминаем параметры передаваемой функции func

        const onFirst = now && !onLast // если хотим запустить функцию func при первом событии движения курсора и время ожидания не установлено

        clearTimeout(onLast) // сбрасываем время ожидания ms

        onLast = setTimeout(() => { // устанавливаем время ожидания

            onLast = null // очищаем переменную onLast
            if (!now) func.apply(context, args) // если при первом событии движения курсора функция func не была вызвана, то вызываем ее когда время ожидания ms закончилось

        }, ms) // подставляем значение параметра ms

        if (onFirst) func.apply(context, args) // запускаем функцию func при первом событии движения курсора

    }
};

window.setHeader = () => {
    if (window.location.pathname !== "/") {
        const header = document.querySelector('.header');
        header.classList.add('fixed');
    } else {
        header.classList.remove('fixed');
    }
}

window.addEventListener('scroll', debounce(runOnScroll, 100));

window.addEventListener("click", debounce(setHeader, 100));


