// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function deleteCat(catId) {
    var req = new XMLHttpRequest();
    req.open("DELETE", "/cat/delete/" + encodeURIComponent(catId));
    req.send();
    console.log('DELETING?', catId);
}