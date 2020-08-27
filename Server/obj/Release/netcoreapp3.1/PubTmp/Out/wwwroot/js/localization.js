window.getDocumentCookie = function () {
    return Promise.resolve(document.cookie);
};

//window.navigatorLanguages = function () {
//    return Promise.resolve(navigator.languages);
//};  
﻿window.blazorCulture = {
    get: () => {
        return "vi";
    },

    set: (value) => {
        window.localStorage['BlazorCulture'] = value;
    }
};
navigatorLanguages = function () {
    return navigator.languages;
}