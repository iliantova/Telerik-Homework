/*Problem 3. Deep copy

Write a function that makes a deep copy of an object.
    The function should work for both primitive and reference types.*/

function copy(object) {
    var copyObject = new Object();
    for (var el in object) {
        if (typeof object[el] === 'object') {
            copyObject[el] = copy(object[el]);
        }
        else {
            copyObject[el] = object[el];
        }
    }
    return copyObject;
}

function deepCopyObj(){

    var person = {
        name: 'Human',
        age: 100,
        pets: {
            name: 'Sharo',
            age: 2,
            home: {
                size: 45
            }
        }
    }

    var pseudoCopy = person,
        copyObj = copy(person);

    jsConsole.writeLine('The original object: ' + person.pets.home.size);

    person.pets.home.size = 1000000;

    jsConsole.writeLine('The original object after modifying: ' + person.pets.home.size);
    jsConsole.writeLine('The pseudoCopy object after modifying: ' + pseudoCopy.pets.home.size);
    jsConsole.writeLine('The deep copied object after modifying: ' + copyObj.pets.home.size);



}

