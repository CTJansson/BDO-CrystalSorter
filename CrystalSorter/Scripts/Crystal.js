$(document).ready(function () {
    GetCrystals();
    copyTextToClipboard('reddit');
});

var selectedRarity;
var selectedSlot;
var selectedLocalization;
var stringToAppend;
var string;

function GetCrystals() {
    selectedRarity = $('#rarity').val();
    selectedSlot = $('#slot').val();
    selectedLocalization = $('#localization').val();

    $.ajax({
        type: 'GET',
        url: '/Home/Crystals',
        dataType: 'JSON',
        type: 'GET',
        success: function (result) {
            $('#tbodyT tr').remove();

            for (var i = 0; i < result.length; i++) {
                string= result[i].Name;
              
                stringToAppend = '<tr><td><div class="color-box" style="background:' + result[i].Rarity + ';"> </div>' + result[i].Name + '<span onclick="copyTextToClipboard(\'' + result[i].Name + '\')" class="glyphicon glyphicon-duplicate glyphicon-floating"> </span></td><td>' + result[i].ItemEffect + '</td><td>' + result[i].Shattering + '</td><td>' + result[i].Slot + '</td><td>' + result[i].Rarity + '</td></tr>';

                if (selectedLocalization == "EU/NA") {
                    if (result[i].Localization == "EU/NA") {
                        AppendCrystal(result[i]);
                    }
                } else if (selectedLocalization == "All") {
                    AppendCrystal(result[i]);
                }
            }
        },
        error: function () {
            console.log('Error getting crystals, this can happen!');
        }
    });
}

function AppendCrystal(result) {
    if (selectedRarity == 'Any') {
        if (selectedSlot == 'All') {
            $('#tbodyT').append(stringToAppend);
        } else if (result.Slot == selectedSlot || result.Slot == 'Any') {
            $('#tbodyT').append(stringToAppend);
        }
    } else if (result.Rarity == selectedRarity) {
        if (selectedSlot == 'All') {
            $('#tbodyT').append(stringToAppend);
        } else if (result.Slot == selectedSlot || result.Slot == 'Any') {
            $('#tbodyT').append(stringToAppend);
        }
    }
}

var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    acc[i].onclick = function () {
        this.classList.toggle("active");
        this.nextElementSibling.classList.toggle("show");
    }
}

function copyTextToClipboard(text) {
    var textArea = document.createElement("textarea");
    textArea.style.position = 'fixed';
    textArea.style.top = 0;
    textArea.style.left = 0;
    textArea.style.width = '2em';
    textArea.style.height = '2em';
    textArea.style.padding = 0;
    textArea.style.border = 'none';
    textArea.style.outline = 'none';
    textArea.style.boxShadow = 'none';
    textArea.style.background = 'transparent';
    textArea.value = text;

    document.body.appendChild(textArea);

    textArea.select();

    try {
        var successful = document.execCommand('copy');
        var msg = successful ? 'successful' : 'unsuccessful';
        console.log('Copying text command was ' + msg);
    } catch (err) {
        console.log('Oops, unable to copy');
    }

    document.body.removeChild(textArea);
}