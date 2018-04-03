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

smoothScrollingTo('#homePage');
smoothScrollingTo('#aboutPage');
smoothScrollingTo('#venuePage');
smoothScrollingTo('#contactPage');

function smoothScrollingTo(target) {
    $('html,body').animate({ scrollTop: $(target).offset().‌​top }, 500);
}

$('a[href*=\\#]').on('click', function (event) {
    event.preventDefault();
    smoothScrollingTo(this.hash);
});
$(document).ready(function () {
    smoothScrollingTo(location.hash);
});