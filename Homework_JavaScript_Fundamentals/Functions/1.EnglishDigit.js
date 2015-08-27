/*Problem 1. English digit

Write a function that returns the last digit of given integer as an English word.
    Examples:

input	output
512	two
1024	four
12309	nine
*/

function LastDigits(){

    var number = jsConsole.read("#tb-first"),
        lastNumber,
        word;

    number = number*1;
    lastNumber = number%10;

    switch (lastNumber) {
        case 0:
            word = "zero";
            break;
        case 1:
            word = "one";
            break;
        case 2:
            word = "two";
            break;
        case 3:
            word = "three";
            break;
        case 4:
            word = "four";
            break;
        case 5:
            word = "five";
            break;
        case 6:
            word = "six";
            break;
        case 7:
            word = "seven";
            break;
        case 8:
            word = "eight";
            break;
        case 9:
            word = "nine";
            break;
}
    jsConsole.writeLine('Last number is:');
    jsConsole.writeLine(word);

}