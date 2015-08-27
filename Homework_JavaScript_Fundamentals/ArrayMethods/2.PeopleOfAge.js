/*Problem 2. People of age

Write a function that checks if an array of person contains only people of age (with age 18 or greater)
Use only array methods and no regular loops (for, while)*/

function(){(function adultPerson(){

    function checkForAdults(people) {
        return people.every(function (person) {
            person.age >= 18;
        });
    }
    var  people = makePeople().slice();

    jsConsole.writeLine('Is all person adult : ' + checkForAdults(people));

})()}




