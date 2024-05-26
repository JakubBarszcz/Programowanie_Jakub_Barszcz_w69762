// Zadanie 1
let liczbyUzytkownika = [];
for (let i = 0; i < 10; i++) {
    liczbyUzytkownika.push(parseInt(prompt("Podaj liczbę całkowitą:")));
}
document.getElementById("zadanie1").innerHTML = `Wpisane liczby: ${liczbyUzytkownika.join(", ")}<br>`;
let wyszukiwanaLiczba = parseInt(prompt("Podaj liczbę, której szukasz:"));
let iloscWystapien = 0;
for (let i = 0; i < liczbyUzytkownika.length; i++) {
    if (liczbyUzytkownika[i] === wyszukiwanaLiczba) {
        iloscWystapien++;
    }
}
document.getElementById("zadanie1").innerHTML += `Liczba ${wyszukiwanaLiczba} występuje ${iloscWystapien} razy w tablicy.<br>`;

// Zadanie 2
let poczatkoweLiczby = [1, 2, 3, 4, 5, 6];
let nowyElement = parseInt(prompt("Podaj liczbę, którą chcesz wstawić:"));
let indeksWstawienia = parseInt(prompt("Podaj indeks, na którym chcesz wstawić liczbę:"));
poczatkoweLiczby.splice(indeksWstawienia, 0, nowyElement);
document.getElementById("zadanie2").innerHTML = `Tablica po wstawieniu nowej liczby: ${poczatkoweLiczby.join(", ")}<br>`;

// Zadanie 3
let ciagDoOdwracania = prompt("Podaj ciąg, który chcesz odwrócić:");
let odwracanyCiag = ciagDoOdwracania.split('').reverse().join('');
document.getElementById("zadanie3").innerHTML = `Odwrócony ciąg: ${odwracanyCiag}<br>`;

// Zadanie 4
function generujLosoweLiczby(ilosc) {
    let tablicaLosowa = [];
    for (let i = 0; i < ilosc; i++) {
        tablicaLosowa.push(Math.floor(Math.random() * 100));
    }
    return tablicaLosowa;
}

function pokazLosoweLiczby() {
    let liczbyLosowe = generujLosoweLiczby(10);
    document.getElementById("losoweLiczby").innerText = liczbyLosowe.join(", ");
}

// Zadanie 5
let przykladowaTablica = [12, 45, 23, 78, 56, 89, 34, 67, 29, 100];
let sumaElementow = przykladowaTablica.reduce((acc, val) => acc + val, 0);
let liczbyParzyste = przykladowaTablica.filter(num => num % 2 === 0);
let pomnozoneElementy = przykladowaTablica.map(num => num * 3);
let numerIndeksu = 69781;
przykladowaTablica.push(numerIndeksu);
let pozycjaNumeruIndeksu = przykladowaTablica.indexOf(numerIndeksu);
let sredniaElementow = sumaElementow / przykladowaTablica.length;
let maksymalnaLiczba = Math.max(...przykladowaTablica);
let wybranyElement = 23;
let iloscWybranegoElementu = przykladowaTablica.filter(num => num === wybranyElement).length;

console.log("Suma elementów:", sumaElementow);
console.log("Liczby parzyste:", liczbyParzyste);
console.log("Pomnożone elementy:", pomnozoneElementy);
console.log("Pozycja numeru indeksu:", pozycjaNumeruIndeksu);
console.log("Średnia elementów:", sredniaElementow);
console.log("Maksymalna liczba:", maksymalnaLiczba);
console.log("Ilość wybranego elementu:", iloscWybranegoElementu);

// Zadanie 6
function generujFibonacci(ilosc) {
    let ciag = [0, 1];
    for (let i = 2; i < ilosc; i++) {
        ciag[i] = ciag[i - 1] + ciag[i - 2];
    }
    return ciag;
}

function pokazFibonacci() {
    let ciagFibonacci = generujFibonacci(100);
    document.getElementById("ciagFibonacci").innerText = ciagFibonacci.join(", ");
}

// Zadanie 7
function znajdzDwieNajwieksze(tablica) {
    let posortowane = tablica.sort((a, b) => b - a);
    return posortowane[0] + posortowane[1];
}
let tablicaLiczb = [12, 45, 23, 78, 56, 89, 34, 67, 29, 100];
document.getElementById("zadanie7").innerHTML = `Suma dwóch największych liczb: ${znajdzDwieNajwieksze(tablicaLiczb)}<br>`;

// Zadanie 8
function usunPowtorzenia(tablica) {
    return [...new Set(tablica)];
}
let duplikatyLiczb = [12, 45, 23, 78, 56, 45, 89, 34, 23, 100];
document.getElementById("zadanie8").innerHTML = `Tablica bez powtórzeń: ${usunPowtorzenia(duplikatyLiczb).join(", ")}<br>`;

// Zadanie 9
function sprawdzCzyPierwsza(liczba) {
    if (liczba <= 1) return false;
    for (let i = 2; i <= Math.sqrt(liczba); i++) {
        if (liczba % i === 0) return false;
    }
    return true;
}
let liczbaDoSprawdzenia = parseInt(prompt("Podaj liczbę do sprawdzenia:"));
document.getElementById("zadanie9").innerHTML = `Czy liczba ${liczbaDoSprawdzenia} jest pierwsza? ${sprawdzCzyPierwsza(liczbaDoSprawdzenia) ? "Tak" : "Nie"}<br>`;
