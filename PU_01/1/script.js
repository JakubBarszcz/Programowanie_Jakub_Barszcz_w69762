document.getElementById('animal-form').addEventListener('submit', function(e) {
    e.preventDefault();

    // Pobieranie wartości z formularza
    const name = document.getElementById('name').value;
    const species = document.getElementById('species').value;
    const age = document.getElementById('age').value;
    const color = document.getElementById('color').value;

    // Dodawanie nowego wiersza do tabeli
    const table = document.querySelector('table tbody');
    const newRow = document.createElement('tr');

    newRow.innerHTML = `
        <td>${name}</td>
        <td>${species}</td>
        <td>${age}</td>
        <td>${color}</td>
    `;

    table.appendChild(newRow);

    // Resetowanie formularza
    document.getElementById('animal-form').reset();

    // Informacja zwrotna dla użytkownika
    alert('Zwierzę zostało dodane!');
});
