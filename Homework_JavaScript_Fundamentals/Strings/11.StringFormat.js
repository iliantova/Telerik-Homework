/*Problem 11. String format

Write a function that formats a string using placeholders.
    The function should work with up to 30 placeholders and all types.
    Examples:

var str = stringFormat('Hello {0}!', 'Peter');
//str = 'Hello Peter!';

var frmt = '{0}, {1}, {0} text {2}';
var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
//str = '1, Pesho, 1 text Gosho'*/


function format(text){
    // A variable that contains all the string arguments
    var selfArguments = arguments;

    return text.replace(/\{(\d+)}/g, function(match, element) {
        return selfArguments[+element + 1];
    })
}

function stringFormat(){

   var textArray = ['{0}, {1}! {2} {3} {4} !', 'Hello', 'World', 'I', 'am', 'here'],
       result = '';
    result += format('{0}, {1}! {2} {3} {4} !', 'Hello', 'World', 'I', 'am', 'here');
    jsConsole.writeLine('Original string');
    jsConsole.writeLine(textArray.join(' '));
    jsConsole.writeLine('Format string');
    jsConsole.writeLine(result);
}