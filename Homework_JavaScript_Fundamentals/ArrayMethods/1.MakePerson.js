/*Problem 1. Make person

Write a function for creating persons.
    Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders*/

function Person (firstname, lastname, age, gender){
    this.firstname = firstname;
        this.lastname = lastname;
        this.age =  age;
        this.gender = gender;
}

function makePeople(){

    var maleFirstNames = ['Ivan', 'Gosho', 'Pesho', 'Atanas', 'Boiko'];
    var maleLastNames = ['Ivanov', 'Georgiev', 'Atanasov', 'Antonov', 'Asenov'];
    var femaleFirstNames = ['Veronika', 'Krasimira', 'Desislava', 'Elena', 'Petq'];
    var femaleLastNames = ['Ivanova', 'Karastancheva', 'Borisova', 'Miroslavova', 'Petrova'];
    var count = 10;
    var people = [];
    var i;

    for (i = 0; i < count; i++) {

        if (Math.random() < 0.5) {
            people.push(new Person(maleFirstNames[Math.floor((Math.random() * 5))],
                maleLastNames[Math.floor((Math.random() * 5))],
                Math.floor((Math.random() * 10) + (Math.random() * 50)),
                false));
        }
        else {
            people.push(new Person(femaleFirstNames[Math.floor((Math.random() * 5))],
                femaleLastNames[Math.floor((Math.random() * 5))],
                Math.floor((Math.random() * 10) + (Math.random() * 50)),
                true));
        }
    }
return people;
}

function printPeople(){

   var  people = makePeople().slice();
    for (var peoples in people) {

        jsConsole.writeLine('Name: ' + people[peoples].firstname + ' ' + people[peoples].lastname + ' age: ' + people[peoples].age + ' Is female: ' + people[peoples].gender );
    }
}

