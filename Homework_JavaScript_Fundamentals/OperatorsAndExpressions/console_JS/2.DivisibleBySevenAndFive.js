//Problem 2. Divisible by 7 and 5
//Write a boolean expression that checks for given integer if it can be divided
// (without remainder) by 7 and 5 in the same time.



//var number = 3;
//var number = 0;
//var number = 5;
//var number = 7;
var number = 35;
//var number = 140;

console.log('Divided by 7 and 5?:');

if(number%5 === 0){
    if(number%7 === 0)
    {
        console.log(true);
    }
    else{
        console.log(false);
    }
}
else{
    console.log(false);
}