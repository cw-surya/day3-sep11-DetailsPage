// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var detailsPanel = document.getElementById('detailsPanel');
var overviewButton = document.getElementById('overviewButton');
var featuresButton = document.getElementById('featuresButton');
var specifiactionButton = document.getElementById('specifiactionButton');

overviewButton.addEventListener("click",() => console.log(overviewButton));

featuresButton.addEventListener("click",() => console.log(featuresButton));

specifiactionButton.addEventListener("click",() => console.log(specifiactionButton));

