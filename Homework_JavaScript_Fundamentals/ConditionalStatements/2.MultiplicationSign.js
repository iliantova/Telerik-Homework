/*Problem 2. Multiplication Sign

Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.*/


function WhatSign(){
    var numberA = jsConsole.readFloat("#tb-first");
    var numberB = jsConsole.readFloat("#tb-second");
    var numberC = jsConsole.readFloat("#tb-third");
if(numberA===0 || numberB ===0 || numberC ===0)
{
    return  jsConsole.writeLine('Sign is "0"');
}
    if(numberA < 0){
        if(numberB < 0){
            if(numberC <0){
              return  jsConsole.writeLine('Sign is "-"');
            }
            else {
              return  jsConsole.writeLine('Sign is "+"');
            }
        }
        else{

            if(numberC <0){
              return  jsConsole.writeLine('Sign is "+"');
            }
            else{
             return   jsConsole.writeLine('Sign is "-"');
            }
        }
    }
    else{

        if(numberB < 0){
            if(numberC <0){
              return  jsConsole.writeLine('Sign is "+"');
            }
            else {
               return jsConsole.writeLine('Sign is "-"');
            }
        }
        else{

            if(numberC <0){
               return jsConsole.writeLine('Sign is "-"');
            }
            else{
              return  jsConsole.writeLine('Sign is "+"');
            }
        }

    }
}

