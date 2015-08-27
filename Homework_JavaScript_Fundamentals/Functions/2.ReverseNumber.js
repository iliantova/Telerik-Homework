/*Problem 2. Reverse number

Write a function that reverses the digits of given decimal number.
    Example:

input	output
256	652
123.45	54.321*/

function reverseNumber(){
    var number = jsConsole.read("#tb-first"),
        reverse = "",
        index,
        lengt = number.length -1;

    for(index in number){
reverse += number[lengt-index];
    }

    jsConsole.writeLine(reverse);
}