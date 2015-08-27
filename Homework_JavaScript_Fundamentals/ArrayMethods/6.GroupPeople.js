/*Problem 6. Group people

Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
Use Array#reduce
Use only array methods and no regular loops (for, while) */

function groupByFirstLetter(people) {
    var grouped = people.reduce(function (group, person) {
        if (group[person.firstName[0]]) {
            group[person.firstName[0]].push(person);
        }
        else {
            group[person.firstName[0]] = [person];
        }

        return group;
    }, {});

    return grouped;
}
function groupFirst(){
x
    var  people = makePeople().slice();
    console.log(groupByFirstLetter(people));


}
