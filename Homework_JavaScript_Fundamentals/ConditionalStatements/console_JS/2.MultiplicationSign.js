/*Problem 2. Multiplication Sign

Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.*/


function WhatSign (){
    var numberA = 5;
    var numberB = -6;
    var numberC = -9;
if(numberA===0 || numberB ===0 || numberC ===0)
{
    return  console.log('Sign is "0"');
}
    if(numberA < 0){
        if(numberB < 0){
            if(numberC <0){
              return  console.log('Sign is "-"');
            }
            else {
              return  console.log('Sign is "+"');
            }
        }
        else{

            if(numberC <0){
              return  console.log('Sign is "+"');
            }
            else{
             return   console.log('Sign is "-"');
            }
        }
    }
    else{

        if(numberB < 0){
            if(numberC <0){
              return  console.log('Sign is "+"');
            }
            else {
               return console.log('Sign is "-"');
            }
        }
        else{

            if(numberC <0){
               return console.log('Sign is "-"');
            }
            else{
              return  console.log('Sign is "+"');
            }
        }

    }
}
WhatSign ();
