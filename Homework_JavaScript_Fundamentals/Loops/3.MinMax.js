//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.


function maxMinSequence(){

    var sequence =  jsConsole.read("#tb-first");
    var numbersArray = sequence.split(' ');
    jsConsole.writeLine(numbersArray);

    numbersArray.sort(compareNumbers);
    var min = numbersArray[0];
   var  max = numbersArray[numbersArray.length - 1];

    function compareNumbers(a, b) {
        return a - b;
    }

    jsConsole.writeLine('Max number is:');
    jsConsole.writeLine(max);
    jsConsole.writeLine('Min number is:');
    jsConsole.writeLine(min);

}

