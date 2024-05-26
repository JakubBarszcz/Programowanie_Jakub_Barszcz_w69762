/// Zadanie2
alert("Hello World!");

// zadani 3
let a = 10, b = 20, c = 23.2;

let wynikDodawania = a + b + c;
alert("Wynik dodawania: " + wynikDodawania);
console.log("Wynik dodawania: " + wynikDodawania);
document.getElementById("wynik-dodawania").innerHTML = "Wynik dodawania: " + wynikDodawania;

let wynikOdejmowania = a - b - c;
alert("Wynik odejmowania: " + wynikOdejmowania);
console.log("Wynik odejmowania: " + wynikOdejmowania);
document.getElementById("wynik-odejmowania").innerHTML = "Wynik odejmowania: " + wynikOdejmowania;

let wynikMnozenia = a * b * c;
alert("Wynik mnożenia: " + wynikMnozenia);
console.log("Wynik mnożenia: " + wynikMnozenia);
document.getElementById("wynik-mnozenia").innerHTML = "Wynik mnożenia: " + wynikMnozenia;

let wynikDzielenia = a / b / c;
alert("Wynik dzielenia: " + wynikDzielenia);
console.log("Wynik dzielenia: " + wynikDzielenia);
document.getElementById("wynik-dzielenia").innerHTML = "Wynik dzielenia: " + wynikDzielenia;

// Zadanie 4
console.log("Liczby parzyste od 0 do 100:");
for (let i = 0; i <= 100; i++) {
    if (i % 2 === 0) {
        console.log(i);
    }
}

// zadanie 5
let bok1,bok2,bok3
bok1 = parseFloat(prompt("podaj długość boku a :"));
bok2 = parseFloat(prompt("podaj długość boku b : "));
bok3 = parseFloat(prompt("podaj długość boku c : "));
let p = (bok1 + bok2 + bok3) / 2;
let poleTrojkata = Math.sqrt(p * (p - bok1) * (p - bok2) * (p - bok3));
console.log("Pole trójkąta: " + poleTrojkata);
document.getElementById("wynik-pola-trojkata").innerHTML = "Pole trójkąta: " + poleTrojkata;

// zadanie 6
let imieUzytkownika = prompt("Podaj swoje imię:");
alert("Witaj, " + imieUzytkownika + "!");

// zadanie 7
let liczba1 = parseInt(prompt("Podaj pierwszą liczbę całkowitą:"));
let liczba2 = parseInt(prompt("Podaj drugą liczbę całkowitą:"));
let wynikSumy = liczba1 + liczba2;
alert("Wynik dodawania: " + wynikSumy);
document.getElementById("wynik-sumy").innerHTML = "Wynik dodawania: " + wynikSumy;

// zadanie 8
let liczba3 = parseFloat(prompt("Podaj pierwszą liczbę:"));
let liczba4 = parseFloat(prompt("Podaj drugą liczbę:"));
let liczba5 = parseFloat(prompt("Podaj trzecią liczbę:"));
let najwiekszaLiczba = Math.max(liczba3, liczba4, liczba5);
console.log("Największa liczba: " + najwiekszaLiczba);
document.getElementById("wynik-najwiekszej-liczby").innerHTML = "Największa liczba: " + najwiekszaLiczba;

// zadanie 9
let liczbaNWD1 = parseInt(prompt("Podaj pierwszą liczbę całkowitą dla NWD:"));
let liczbaNWD2 = parseInt(prompt("Podaj drugą liczbę całkowitą dla NWD:"));
while (liczbaNWD2 !== 0) {
    let temp = liczbaNWD2;
    liczbaNWD2 = liczbaNWD1 % liczbaNWD2;
    liczbaNWD1 = temp;
}
alert("Największy wspólny dzielnik: " + liczbaNWD1);
document.getElementById("wynik-nwd").innerHTML = "Największy wspólny dzielnik: " + liczbaNWD1;
