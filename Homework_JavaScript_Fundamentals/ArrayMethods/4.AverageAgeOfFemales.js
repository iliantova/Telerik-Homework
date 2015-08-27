/*Problem 4. Average age of females

Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
Use only array methods and no regular loops (for, while)*/


function avarageAge(){

    var  people = makePeople().slice();

   var result = people.filter(function(person){
        return person.gender === true;
    }).reduce(function (sum, person, index, array) {
        count = array.length;
        jsConsole.writeLine('Name: ' + person.firstname + ' ' + person.lastname + ' age: ' + person.age);
       return (sum + person.age / count);
    }, 0);

    jsConsole.writeLine('Avarage age is: ' + result);

}


