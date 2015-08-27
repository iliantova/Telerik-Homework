/*Problem 1. Numbers
Write a script that prints all the numbers from 1 to N.*/

function numberPrintToN(){

    var number = jsConsole.readInteger("#tb-first");
    var i = 1;
    var result = new Array(number);

    for (i; i<=number; i+=1){

        result[i-1] = i;
    }
    jsConsole.writeLine('Numbers from 1 ton N:')
    jsConsole.writeLine(result.join(', '));

}
