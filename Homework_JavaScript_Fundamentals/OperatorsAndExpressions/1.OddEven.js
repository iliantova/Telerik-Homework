//Problem 1. Odd or Even
//Write an expression that checks if given integer is odd or even.


function oddEven() {
    var number = jsConsole.readFloat("#tb-first");
    if (number % 2 !== 0) {
        jsConsole.writeLine('Is number odd? : ' + true)
    } else {
        jsConsole.writeLine('Is number odd? : ' + false)
    }
}
