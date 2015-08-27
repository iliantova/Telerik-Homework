/*Problem 6.

Write a function that groups an array of people by age, first or last name.
    The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function)

Example:

    var people = {…};
var groupedByFname = group(people, 'firstname');
var groupedByAge= group(people, 'age');
*/

function groupPeople(arr, key) {
    if (!arr.length) {
        return undefined;
    }
    var groupedPeople = {};
    for (var i = 0; i < arr.length; i++) {
        var currentPerson = arr[i];
        if (!groupedPeople[currentPerson[key]]) {
            groupedPeople[currentPerson[key]] = [];
        }
        groupedPeople[currentPerson[key]].push(currentPerson.firstname + ' ' +currentPerson.lastname + ' ');
    }
    return groupedPeople;
}

function groupPeopleProp(){

    var people = [
        { firstname : 'Ivan', lastname: 'Ivanov', age: 25 },
        { firstname : 'Dragan', lastname: 'Ivanov', age: 81},
        { firstname : 'Miroslav', lastname: 'Miroslavov', age: 43 },
        { firstname : 'Kaloqn', lastname: 'Kaloqnov', age: 43 },
        { firstname : 'Miroslav', lastname: 'Gospodinov', age: 25 },
        { firstname : 'Miroslav', lastname: 'Petrov', age: 25 },
        { firstname : 'Ivelin', lastname: 'Ivanov', age: 81 }];

var groupByprop = jsConsole.read("#tb-first");

    var groupPeopleBy = groupPeople(people, groupByprop);

    jsConsole.writeLine('Group people by ' + groupByprop);

    for (var key in groupPeopleBy) {

            jsConsole.writeLine(key + ':  '+ groupPeopleBy[key]);
        }





}







