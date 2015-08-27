/*Problem 2. Remove elements

Write a function that removes all elements with a given value.
    Attach it to the array type.
    Read about prototype and how to attach methods.

    var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];*/

Array.prototype.remove = function (element) {
    var resultArr = [];
    for (var i = 0; i < this.length; i += 1) {
        if (this[i] !== element) {
            resultArr.push(this[i]);
        }
    }
    this.length = 0;
    for (var i = 0; i < resultArr.length; i += 1) {
        this[i] = resultArr[i];
    }
    return this;
};

function removeElement(){

    var stringOne = jsConsole.read("#tb-first"),
        arrayOne = stringOne.split(', '),
        number = jsConsole.read("#tb-second");
    jsConsole.writeLine('Your array: ' + arrayOne.join(', '));

        arrayOne.remove(number);

    jsConsole.writeLine('Array with remove element: ' + arrayOne.join(', '));


}