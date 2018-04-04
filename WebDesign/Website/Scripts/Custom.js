function initMap() {
    var uluru = { address: 'Gale St, Dagenham RM9 4UN', };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 4,
        center: uluru
    });
    var marker = new google.maps.Marker({
        position: uluru,
        map: map
    });
};


$(document).ready(function () {
    $("a").on('click', function (event) {
        if (this.hash !== "") {
            event.preventDefault();
            var hash = this.hash;
            if (hash == "#home") {
                $('html, body').animate({
                    scrollTop: 0
                }, 800, function () {
                    window.location.hash = hash;
                });
            }
            $('html, body').animate({
                scrollTop: ($(hash).offset().top -80)
            }, 800, function () {
                window.location.hash = hash;
            });
        }
    })
})
