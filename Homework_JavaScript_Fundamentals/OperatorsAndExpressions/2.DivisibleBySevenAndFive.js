//Problem 2. Divisible by 7 and 5
//Write a boolean expression that checks for given integer if it can be divided
// (without remainder) by 7 and 5 in the same time.


function DivisibleBySevenAndFive(){
    var number = jsConsole.readFloat("#tb-first");
    if(number%5 === 0){
        if(number%7 === 0)
        {
            jsConsole.writeLine('Divided by 7 and 5?: ' + true);
        }
        else{
            jsConsole.writeLine('Divided by 7 and 5?: ' + false);
        }
    }
    else{
        jsConsole.writeLine('Divided by 7 and 5?: ' + false);
    }
}


