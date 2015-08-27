/*Problem 5. Appearance count

Write a function that counts how many times given number appears in given array.
    Write a test function to check if the function is working correctly.*/

function numberInArray(){
    var input = jsConsole.read("#tb-first"),
            array = input.split(', ').map(function(x){return x*1;}),
        inputN = jsConsole.read("#tb-second"),
        number = inputN*1;

        function countOccurences(array1, number1) {
        var count = 0;

        for (var i = 0; i < array1.length; i++) {
            if (array1[i] === number1) {
                count++;
            }
        }

        return count;
    }
    jsConsole.writeLine('Number appears in given array: ' + countOccurences(array, number) + 'time');
    function testGetNumOccurances() {
        var testArr = [4, 34, 43, 2, 9, 4, 9, -56, 4, 17, 34, 4, 2, 11, 9];

        if (countOccurences(testArr,4) === 4 &&
            countOccurences(testArr,9) === 3 &&
            countOccurences(testArr,-56) === 1 &&
            countOccurences(testArr,0) === 0) {

            return 'Correct!';
        }
        else {
            return 'Incorrect!';
        }
    }


    jsConsole.writeLine(testGetNumOccurances())






}