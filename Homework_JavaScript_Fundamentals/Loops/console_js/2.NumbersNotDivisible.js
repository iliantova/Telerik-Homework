/*Problem 2. Numbers not divisible

Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time*/

var number = 15;
var i = 1;
var count = 0;
var result = new Array();

for (i; i<=number; i+=1){

    if(!((i%3===0)&&(i%7==0))){

        result[count] = i;
        count+=1;

    }

}

console.log(result.join(', '));
