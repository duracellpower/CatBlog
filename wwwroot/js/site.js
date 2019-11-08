function deleteCat(catId) {
    var req = new XMLHttpRequest();
    req.open("DELETE", "/cat/delete/" + encodeURIComponent(catId));
    req.onreadystatechange = function (ev) {
        if (req.status === 200) {
            window.location.reload();
        }
    };
    req.send();
}