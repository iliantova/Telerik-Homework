/*Problem 2. Correct brackets

Write a JavaScript function to check if in a given expression the brackets are put correctly.
    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).*/


function checkForCorrectBrackets(expression) {
    var count = 0;

    for (var char in expression) {
        if (expression[char] === '(') {
            count += 1;
        }
        if (expression[char] === ')') {
            count -= 1;
        }
        if (count < 0) {
            return false;
        }
    }
    if (count !== 0) {
        return false;
    }

    return true;
}

function checkBrackets (){

    var inputString = jsConsole.read("#tb-first"),
        checkbrakets = checkForCorrectBrackets(inputString);
    if (checkbrakets){

        jsConsole.writeLine('Bracket expression is CORRECT!');

    }
    else{
        jsConsole.writeLine('Brackets expression is INCORRECT!');
    }

}