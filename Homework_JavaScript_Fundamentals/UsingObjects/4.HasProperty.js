/*Problem 4. Has property

Write a function that checks if a given object contains a given property.

    var obj  = …;
var hasProp = hasProperty(obj, 'length');*/

function hasProperty(obj, property) {
    for (var prop in obj) {
        if (prop === property) {
            return true;
        }
    }
    return false;
}

function proportyCheck() {

    var prop = jsConsole.read("#tb-first"),
        person = {
        name: 'Human',
        age: 100,
        gender: 'male',
        education: 'university'
    };

    if(hasProperty(person, prop)){

        jsConsole.writeLine('There is a property ' + prop + ' in object');

    }
    else{

        jsConsole.writeLine('There is not a property ' + prop + ' in object');
    }

}

