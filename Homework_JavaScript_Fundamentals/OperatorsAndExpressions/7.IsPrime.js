/*7. Write an expression that checks if given positive integer number n (n ? 100) is prime.*/


function checkIfPrime(){
    var i = 2;
    var number = jsConsole.readInteger("#tb-first");
    var rezult = true;
    if (number < 2) {
        rezult = false;
    }
    else{
        for (i; i <= Math.sqrt(number) ; i += 1) {
            if (number % i === 0) {
                rezult = false;
                break;
            }
        }
    }

    jsConsole.writeLine('The number is prime: ' + rezult);
}


