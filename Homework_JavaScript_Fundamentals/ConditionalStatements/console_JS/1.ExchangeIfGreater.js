/*Problem 1. Exchange if greater

    Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
    As a result print the values a and b, separated by a space.*/


function FirstSecont() {
    var numberA = 5;
    var numberB = 2;
    var bigger;

    if(numberA > numberB){
        bigger = numberB;
        numberB = numberA;
        numberA = bigger;
    }
}
FirstSecont();
console.log(numberA + ' '+ numberB);