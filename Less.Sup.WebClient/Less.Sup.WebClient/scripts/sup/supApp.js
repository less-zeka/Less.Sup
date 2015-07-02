var supApp = angular.module('supApp', ['ngResource']);
// looks good, didn't work yet. map was not loaded correctly
// check back later
//http://stackoverflow.com/questions/17494732/how-to-make-a-loading-indicator-for-every-asynchronous-action-using-q-in-an-a

supApp.controller('routeCtrl', function($scope, $http, $resource) {

    $scope.isLoading = true;
    //get User Coordinates
    $scope.userLocationLatitude = 0.0;
    $scope.userLocationLongitude = 0.0;
    //TODO async or similar; promises?
    navigator.geolocation.getCurrentPosition(function(position) {
        $scope.userLocationLatitude = position.coords.latitude;
        $scope.userLocationLongitude = position.coords.longitude;
        $scope.$apply();
        getRouteData($resource);
    });

    /*
    gets the closest route (distance from any route point to current user position) from an WebApi i made
    */
    var getRouteData = function($resource) {
        $http.defaults.useXDomain = true;
        var uri = 'http://sup-webapi.cheese-maker.ch/api/Route';
        routeApi = $resource(uri);

        routeApi.get({ longitude: $scope.userLocationLongitude, latitude: $scope.userLocationLatitude })
            .$promise.then(function(route) {
                    route.routeInfo = 'No danger ' +
                        'water is calm' +
                        'paddle strength: ++';
                    $scope.route = route;

                    showRoute($resource);
                },
                function(response) {
                    // TODO: handle the error somehow
                }).finally(function() {
                // called no matter success or failure
                $scope.isLoading = false;
            });
    }
    var showRoute = function($resource) {
        window.google.maps.visualRefresh = true;
        var center = new window.google.maps.LatLng($scope.route.Location[0].Latitude, $scope.route.Location[0].Longitude);
        // These are options that set initial zoom level, where the map is centered globally to start, and the type of map to show
        var mapOptions = {
            zoom: 13,
            center: center,
            mapTypeId: window.google.maps.MapTypeId.G_NORMAL_MAP
        };

        // This makes the div with id "map_canvas" a google map
        map = new window.google.maps.Map(document.getElementById("map_canvas"), mapOptions);

        createMarker('Your current position', $scope.userLocationLatitude, $scope.userLocationLongitude, 'http://maps.google.com/mapfiles/ms/icons/red-dot.png');
        //createInfoWindow('Your current position');

        $.each($scope.route.Location, function(i, item) {
            var marker = createMarker(item.info, item.Latitude, item.Longitude, 'http://maps.google.com/mapfiles/ms/icons/blue-dot.png');
            createInfoWindow(marker, item.info, item.info)
        });
        //TODO use JS "await" so code has not to be written like that
        getWeatherData($resource);
    };

    // TODO check this
    // http://stackoverflow.com/questions/18751185/basic-ajax-get-call-with-angularjs
    var getWeatherData = function($resource) {
        var appId = "a95cadf12d5ad0ce241f977b01891f93";
        var uri = "http://api.openweathermap.org/data/2.5/weather";
        $http.defaults.useXDomain = true;

        weatherApi = $resource(uri);

        actionObject = {
            transformResponse: function(response) {
                // whatever you want to do
                alert(response);
                return response;
            }
        }

        weatherApi.get({ APPID: appId, lat: $scope.route.Location[0].Latitude, lon: $scope.route.Location[0].Longitude, mode: 'html' })
            .$promise.then(function (data) {
                //TODO doesn't work
                $scope.Weather = data;
                //$("#weather").html(data);
            });
    };

    var createMarker = function(title, lat, lon, icon) {
        var marker = {};
        marker = new window.google.maps.Marker({
            'position': new window.google.maps.LatLng(lat, lon),
            'map': map,
            'title': title
        });

        marker.setIcon(icon);
        return marker;
    }

    var createInfoWindow = function(marker, title, info) {
        var infowindow = new window.google.maps.InfoWindow({ content: getContent(title, info) });

        // finally hook up an "OnClick" listener to the map so it pops up out info-window when the marker-pin is clicked!
        window.google.maps.event.addListener(marker, 'click', function() {
            infowindow.open(map, marker);
        });
    }

    var getContent = function(title, info) {
        if ('null' != title) {
            if ('null' != info) {
                return "<div class='infoDiv'><h2>" + title + "</h2>" + "<div><h4>Info: " + info + "</h4></div></div>";
            }
            return "<div class='infoDiv'><h2>" + title + "</h2></div>";
        }
    }
});