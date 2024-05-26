document.addEventListener('DOMContentLoaded', function() {
    var formularz = document.getElementById('formularzRejestracyjny');
    var telefon = document.getElementById('telefon');
    var kraj = document.getElementById('kraj');
    var wojewodztwo = document.getElementById('wojewodztwo');
    var adresKorespondencyjnyTakiSam = document.getElementById('adresKorespondencyjnyTakiSam');
    var adresKorespondencyjnyPole = document.getElementById('adresKorespondencyjnyPole');
    var adresKorespondencyjny = document.getElementById('adresKorespondencyjny');
    var dataUrodzenia = document.getElementById('dataUrodzenia');
    var haslo = document.getElementById('haslo');
    var powtorzHaslo = document.getElementById('powtorzHaslo');

    telefon.addEventListener('input', function() {
        telefon.value = telefon.value.replace(/\D/g, '');
    });

    kraj.addEventListener('change', function() {
        if (kraj.value === 'Polska') {
            wojewodztwo.disabled = false;
        } else {
            wojewodztwo.disabled = true;
        }
    });

    wojewodztwo.addEventListener('change', function() {
        var adresZamieszkania = document.getElementById('adresZamieszkania');
        if (wojewodztwo.value === '') {
            adresZamieszkania.disabled = true;
            adresKorespondencyjny.disabled = true;
        } else {
            adresZamieszkania.disabled = false;
            adresKorespondencyjny.disabled = false;
        }
    });

    adresKorespondencyjnyTakiSam.addEventListener('change', function() {
        if (adresKorespondencyjnyTakiSam.checked) {
            adresKorespondencyjnyPole.style.display = 'none';
            adresKorespondencyjny.disabled = true;
        } else {
            adresKorespondencyjnyPole.style.display = 'block';
            adresKorespondencyjny.disabled = false;
        }
    });

    formularz.addEventListener('submit', function(event) {
        event.preventDefault();

        var valid = true;

        if (!sprawdzPelnoletnosc(dataUrodzenia.value)) {
            dataUrodzenia.setCustomValidity('Musisz być pełnoletni.');
            valid = false;
        } else {
            dataUrodzenia.setCustomValidity('');
        }

        if (haslo.value !== powtorzHaslo.value) {
            powtorzHaslo.setCustomValidity('Hasła muszą być takie same.');
            valid = false;
        } else {
            powtorzHaslo.setCustomValidity('');
        }

        var pola = formularz.querySelectorAll('input, select');
        pola.forEach(function(pole) {
            if (!pole.checkValidity()) {
                valid = false;
                pole.reportValidity();
            }
        });

        if (valid) {
            alert('Formularz został pomyślnie wypełniony!');
        }
    });

    haslo.addEventListener('input', function() {
        powtorzHaslo.setCustomValidity('');
    });

    powtorzHaslo.addEventListener('input', function() {
        powtorzHaslo.setCustomValidity('');
    });

    function sprawdzPelnoletnosc(data) {
        var dataUrodzenia = new Date(data);
        var dzisiaj = new Date();
        var wiek = dzisiaj.getFullYear() - dataUrodzenia.getFullYear();
        var miesiac = dzisiaj.getMonth() - dataUrodzenia.getMonth();
        if (miesiac < 0 || (miesiac === 0 && dzisiaj.getDate() < dataUrodzenia.getDate())) {
            wiek--;
        }
        return wiek >= 18;
    }
});
