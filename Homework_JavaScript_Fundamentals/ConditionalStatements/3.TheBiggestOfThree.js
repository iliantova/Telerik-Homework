/*Problem 3. The biggest of Three

Write a script that finds the biggest of three numbers.
    Use nested if statements.*/



function BigestOfTree () {
    var numberA = jsConsole.readFloat("#tb-first");
    var numberB = jsConsole.readFloat("#tb-second");
    var numberC = jsConsole.readFloat("#tb-third");
    var biggest = numberA;

    if(biggest < numberB){
        biggest = numberB;

    }

    if (biggest < numberC){
        biggest = numberC;
    }

    jsConsole.writeLine('The biggest number is: '+ biggest);
}


