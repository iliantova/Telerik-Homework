/*Problem 1. Numbers
Write a script that prints all the numbers from 1 to N.*/

var number = 9;
var i = 1;
var result = new Array(number);

for (i; i<=number; i+=1){

    result[i-1] = i;
}

console.log(result.join(', '));