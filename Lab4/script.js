function init() {
    sprawdzWiek();
    odliczanieFor();
    odliczanieWhile();
}

// Zadanie 1
function odliczanieFor() {
    console.log("Odliczanie (for):");
    for (var i = 10; i > 0; i--) {
        console.log(i);
    }
    console.log("Happy New Year!");
}

function odliczanieWhile() {
    console.log("Odliczanie (while):");
    var i = 10;
    while (i > 0) {
        console.log(i);
        i--;
    }
    console.log("Happy New Year!");
}

// Zadanie 2
function obliczSilnia() {
    var liczba = parseInt(document.getElementById('inputSilnia').value);
    var wynik = 1;
    for (var i = 2; i <= liczba; i++) {
        wynik *= i;
    }
    document.getElementById('wynikSilnia').innerText = 'Silnia z ' + liczba + ' to ' + wynik;
}

// Zadanie 3
function sprawdzWiek() {
    var wiek = prompt("Podaj swój wiek:");
    if (parseInt(wiek) < 18) {
        window.open('https://www.w3schools.com/jsref/met_win_open.asp', '_self');
    }
}

// Zadanie 4
function zmienKolor(przycisk) {
    var przyciski = document.querySelectorAll('.przyciskKolor');
    for (var i = 0; i < przyciski.length; i++) {
        przyciski[i].classList.remove('podswietlenie');
    }
    przycisk.classList.add('podswietlenie');
}

// Zadanie 5
function zmienWidocznosc() {
    var element = document.getElementById('elementWidocznosc');
    if (element.style.display === 'none') {
        element.style.display = 'block';
    } else {
        element.style.display = 'none';
    }
}

// zadanie 6
function dodajDoListy() {
    var wartoscInput = document.getElementById('inputLista').value;
    var ul = document.getElementById('listaWartosci');
    var li = document.createElement('li');
    li.textContent = wartoscInput;
    ul.appendChild(li);
}

// Zadanie 7
function dodajDoTabeli() {
    var imie = document.getElementById('inputImie').value;
    var nazwisko = document.getElementById('inputNazwisko').value;
    var tbody = document.getElementById('tabelaImionaNazwiska');

    var wiersz = document.createElement('tr');
    var komorkaImie = document.createElement('td');
    komorkaImie.textContent = imie;
    var komorkaNazwisko = document.createElement('td');
    komorkaNazwisko.textContent = nazwisko;

    wiersz.appendChild(komorkaImie);
    wiersz.appendChild(komorkaNazwisko);
    tbody.appendChild(wiersz);

    document.getElementById('inputImie').value = '';
    document.getElementById('inputNazwisko').value = '';
}

// Zadanie 8
function konwertujNaF() {
    var celsius = parseFloat(document.getElementById('inputTemp').value);
    var fahrenheit = (celsius * 9/5) + 32;
    document.getElementById('wynikTemp').innerText = celsius + '°C to ' + fahrenheit.toFixed(2) + '°F';
}

function konwertujNaC() {
    var fahrenheit = parseFloat(document.getElementById('inputTemp').value);
    var celsius = (fahrenheit - 32) * 5/9;
    document.getElementById('wynikTemp').innerText = fahrenheit + '°F to ' + celsius.toFixed(2) + '°C';
}

// Zadanie 10
function kalkuluj(operacja) {
    var liczba1 = parseFloat(document.getElementById('inputKalk1').value);
    var liczba2 = parseFloat(document.getElementById('inputKalk2').value);
    var wynik;

    if (operacja === 'dodaj') {
        wynik = liczba1 + liczba2;
    } else if (operacja === 'odejmij') {
        wynik = liczba1 - liczba2;
    } else if (operacja === 'mnozenie') {
        wynik = liczba1 * liczba2;
    } else if (operacja === 'dzielenie') {
        if (liczba2 === 0) {
            alert("Nie można dzielić przez zero");
            return;
        }
        wynik = liczba1 / liczba2;
    } else if (operacja === 'potegowanie') {
        wynik = Math.pow(liczba1, liczba2);
    } else {
        wynik = 'Nieznana operacja';
    }

    document.getElementById('wynikKalk').innerText = 'Wynik: ' + wynik;
}
