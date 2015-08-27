//Problem 4. Third digit
//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

function isThirdDigitSeven() {
    var number = jsConsole.readInteger("#tb-first");
    var rezult = (Math.floor(number / 100) % 10) == 7;
    jsConsole.writeLine('Third digit in ' + number + ' is seven - ' + rezult );
}

