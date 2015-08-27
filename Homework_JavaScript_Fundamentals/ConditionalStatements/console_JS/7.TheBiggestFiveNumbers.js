/*Problem 7. The biggest of five numbers

Write a script that finds the greatest of given 5 variables.
    Use nested if statements.*/

function BiggestNumber(){
    var numberA = 12;
    var numberB = 11;
    var numberC = 8;
    var numberD = 2;
    var numberE= 500;
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

    console.log('The biggest number is: ' + max);
}
BiggestNumber();