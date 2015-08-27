/*Problem 5. Youngest person

Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
    Use Array#find*/
function youngestMale(){

    if (!Array.prototype.find) {
        Array.prototype.find = function (callback) {
            var i,
                len;

            for (i = 0, len = this.length; i < len; i += 1) {
                if (callback(this[i], i, this)) {
                    return this[i];
                }
            }

            return undefined;
        };
    }

    var  people = makePeople().slice();

    function getNamesOfYoungestMale (people) {
        var youngestMale =  people.sort(function (a, b) {
            return a.age - b.age;
        }).find(function(person) {
            return !person.gender;
        })

        return jsConsole.writeLine('Name: ' + youngestMale.firstname + ' ' + youngestMale.lastname + ' age: ' + youngestMale.age);
    }
people.forEach(function (person) {
    jsConsole.writeLine('Name: ' + person.firstname + ' ' + person.lastname + ' age: ' + person.age);
});
    jsConsole.writeLine(' ');
    jsConsole.writeLine('Youngest male person in a array is:');
    getNamesOfYoungestMale(people);

}
