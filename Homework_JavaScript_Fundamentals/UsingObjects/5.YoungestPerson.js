


function findYoungestPerson(arrOfPeople) {
    var minAge = arrOfPeople[0].age;
    var youngestPerson = arrOfPeople[0];
    for (var person in arrOfPeople) {
        if (arrOfPeople[person].age < minAge) {
            minAge = arrOfPeople[person].age;
            youngestPerson = arrOfPeople[person];
        }
    }
    return youngestPerson
}

function checkYongest(){

    var people = [
        { firstname : 'Ivan', lastname: 'Ivanov', age: 25 },
        { firstname : 'Dragan', lastname: 'Draganov', age: 81},
        { firstname : 'Miroslav', lastname: 'Miroslavov', age: 32 },
        { firstname : 'Ivelina', lastname: 'Ivelinova', age: 15 }];

var youngest = findYoungestPerson(people);

    jsConsole.writeLine('The youngest person names are: ' + youngest.firstname + ' ' + youngest.lastname);

}