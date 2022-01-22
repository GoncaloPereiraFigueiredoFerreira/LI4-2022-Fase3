
function addLocationToUrl(url) {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var latitude = position.coords.latitude;
            var longitude = position.coords.longitude
            location.href = url + "latitude=" + latitude + "&longitude=" + longitude;
        });
    } else {
        alert("Geolocation is not supported by this browser");
        location.href = url + "latitude=" + "41.5616691819986" + "&longitude=" + "-8.397289566815399";
    }
}