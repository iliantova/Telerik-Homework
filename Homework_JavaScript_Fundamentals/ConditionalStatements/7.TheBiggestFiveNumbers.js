/*Problem 7. The biggest of five numbers

Write a script that finds the greatest of given 5 variables.
    Use nested if statements.*/

function BiggestNumber(){
    var numberA = jsConsole.readFloat("#tb-first");
    var numberB = jsConsole.readFloat("#tb-second");
    var numberC = jsConsole.readFloat("#tb-third");
    var numberD = jsConsole.readFloat("#tb-fourth");
    var numberE = jsConsole.readFloat("#tb-fifth");
    var max = numberA;
    if(numberB > max){
        max = numberB;
    }
    if(numberC > max){
        max = numberC;
    }
    if(numberD > max){
        max = numberD;
    }
    if(numberE  >max){
        max = numberE;
    }

    jsConsole.writeLine('The biggest number is: ' + max);
}