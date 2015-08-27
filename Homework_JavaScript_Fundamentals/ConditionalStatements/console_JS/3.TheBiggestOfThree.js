/*Problem 3. The biggest of Three

Write a script that finds the biggest of three numbers.
    Use nested if statements.*/



function BigestOfTree () {
    var numberA = 5;
    var numberB = 6;
    var numberC = 9;
    var biggest = numberA;

    if(biggest < numberB){
        biggest = numberB;

    }

    if (biggest < numberC){
        biggest = numberC;
    }
     return biggest;
}

console.log('The biggest number is: '+ BigestOfTree());
