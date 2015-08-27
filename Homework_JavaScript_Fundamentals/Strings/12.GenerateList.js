/*Problem 12. Generate list

Write a function that creates a HTML <ul> using a template for every HTML <li>.
The source of the list should be an array of elements.
    Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
    Example: HTML:

    <div data-type="template" id="list-item">
    <strong>-{name}-</strong> <span>-{age}-</span>
/div>
JavaScript:

var people = [{name: 'Peter', age: 14},…];
var tmpl = document.getElementById('list-item').innerHtml;
var peopleList = generateList(people, template);
//peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'*/


function getArrayOfPeople() {
    function Person(name,age) {
        this.name = name;
        this.age = age;
    }
    var people = [],
        count = Math.random() * 50,
        names = ['Joro','Ivan','Pesho','Galin','Todor','Mihail'];
    for(var i =0; i < count; i++) {
        people.push(new Person(names[Math.floor(Math.random() * 6)],Math.floor(Math.random()*50)));
    }
    return people;
}
(function () {
    var people = getArrayOfPeople();
    var template = document.getElementById('list-item').innerHTML;
    var peopleList = generateList(people, template);
    document.body.appendChild(peopleList);
    function generateList(people, template) {
        var unorderList = document.createElement('ul');
        for(var i = 0; i < people.length; i++) {
            var currentPerson = people[i],
                listItem = document.createElement('li'),
                innerText = '';
            innerText = template.replace('-{name}-',currentPerson.name);
            innerText = innerText.replace('-{age}-',currentPerson.age);
            listItem.innerHTML = innerText;
            unorderList.appendChild(listItem);
        }
        return unorderList;
    }
})();