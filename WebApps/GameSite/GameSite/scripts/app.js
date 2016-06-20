// Define the `phonecatApp` module
var gamerApp = angular.module('gamerApp', []);

// Define the `PhoneListController` controller on the `phonecatApp` module
gamerApp.controller('gameEngineController', function PhoneListController($scope) {
    
    $scope.startSlots = function () {
        var soapMessage =
            "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:tem=\"http://tempuri.org/\">"+
            "<soapenv:Header/>"+
            "<soapenv:Body>"+
            "<tem:StartEngine/>"+
            "</soapenv:Body>"+
            "</soapenv:Envelope>";

            $.ajax({
                url: "http://localhost:53726/SlotsEngineCommunicator.svc", 
                type: "POST",
                dataType: "xml", 
                data: soapMessage, 
                processData: false,
                contentType: "text/xml; charset=\"utf-8\"",
                success: function (data, status) {
                    alert(data.StartEngineResponse);
                },
                error: function (request, status, error) {
                    alert("Error: " + error)
                }
            });
    }
});

 