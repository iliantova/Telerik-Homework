/*7. Write an expression that checks if given positive integer number n (n ? 100) is prime.*/

//var number = 1;
//var number = 2;
//var number = 3;
//var number = 4;
//var number = 9;
//var number = 37;
//var number = 97;
var number = 51;
//var number = -3;
//var number = 0;


var i = 2;

function checkIfPrime(number){
    if (number < 2) {
        return false;
    }

    for (i; i <= Math.sqrt(number) ; i += 1) {
        if (number % i === 0) {
            return false;
        }
        return true;
    }
}


console.log('The number is prime: ' + checkIfPrime(number));