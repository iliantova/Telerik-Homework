//Problem 4. Third digit
//Write an expression that checks for given integer if its third digit (right-to-left) is 7.


//var number = 5;
//var number = 701;
//var number = 1732;
var number = 9703;
//var number = 877;
//var number = 777877;
//var number = 9999799;

function isThirdDigitSeven(number) {
    return (Math.floor(number / 100) % 10) == 7;
}

console.log('Third digit in ' + number + ' is seven - ' + isThirdDigitSeven(number));