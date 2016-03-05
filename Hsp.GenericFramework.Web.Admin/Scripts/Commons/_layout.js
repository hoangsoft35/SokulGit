$(document).ready(function () {
    
});
function ChangeLanguage(languageId) {
    var url = rootPath + "/Account/Changelanguage?languageId=" + languageId + "&returnUrl=" + window.location.pathname;
    window.location = url;
}