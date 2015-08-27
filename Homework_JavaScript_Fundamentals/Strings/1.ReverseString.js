/*Problem 1. Reverse string

Write a JavaScript function that reverses a string and returns it.
    Example:

input	output
sample	elpmas*/

function reverseString(word) {
    word = word.split('').reverse().join('');
    return word;
}

function stringReverseFubction(){

    var inputString = jsConsole.read("#tb-first"),
        reversedString;

    reversedString = reverseString(inputString);
    jsConsole.writeLine('Reversed string: ' + reversedString);
}