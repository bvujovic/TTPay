// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function EntryDataChange() {
    // numUkPlaceno.value = numUkTrosak.value;

    var igraloLjudi = chkBTrosak.checked + chkZTrosak.checked + chkMTrosak.checked;
    var trosakCovek = Math.round(numUkTrosak.value / igraloLjudi * 100) / 100;
    numBTrosak.value = chkBTrosak.checked ? trosakCovek : 0;
    numZTrosak.value = chkZTrosak.checked ? trosakCovek : 0;
    numMTrosak.value = chkMTrosak.checked ? trosakCovek : 0;

    var platiloLjudi = chkBPlaceno.checked + chkMPlaceno.checked + chkZPlaceno.checked;
    var platioCovek = Math.round(numUkPlaceno.value / platiloLjudi);
    numBPlaceno.value = chkBPlaceno.checked ? platioCovek : 0;
    numZPlaceno.value = chkZPlaceno.checked ? platioCovek : 0;
    numMPlaceno.value = chkMPlaceno.checked ? platioCovek : 0;
}