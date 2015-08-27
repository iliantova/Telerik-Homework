/*Problem 3. Underage people

Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while)*/

function underagePerson(){

    var  people = makePeople().slice();
    people.filter(function(person){
        return person.age < 18;
    }).forEach(function (person) {
        jsConsole.writeLine('Name: ' + person.firstname + ' ' + person.lastname + ' age: ' + person.age);
    });




}


