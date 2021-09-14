
const animals = [
    {
        name: "Fluffy", species: "cat", class: { name: 'mamalia' }
    },
    {
        name: "Nemo", species: "dog", class: { name: 'vertebrata' }
    },
    {
        name: "Ursa", species: "cat", class: { name: 'mamalia' }
    }
]

console.log(animals)

var allAnimals = [];
var cats = [];

animals.forEach((animal) => {
    if (animal.species == "dog") {
        animal.class.name = "non-mammals"
    }
    if (animal.species == "cat") {
        cats.push(animal);
    }
    allAnimals.push(animal);
});

var dogs = allAnimals.filter(animal => animal.species == "dog");

//console.log(allAnimals);
//console.log(cats);
//console.log(dogs);