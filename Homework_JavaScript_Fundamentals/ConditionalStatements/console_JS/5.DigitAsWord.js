/*Problem 5. Digit as word

Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print �not a digit� in case of invalid input.
    Use a switch statement.*/

function convertDigit(){
    var input = '9';
    switch(input){
        case '0': result= 'zero';break;
        case '1': result= 'one';break;
        case '2': result= 'two';break;
        case '3': result='three';break;
        case '4': result='four';break;
        case '5': result='five';break;
        case '6': result='six';break;
        case '7': result='seven';break;
        case '8': result='eight';break;
        case '9': result='nine';break;
        default: result='not a digit';
    }

   return console.log(result)
}
convertDigit();