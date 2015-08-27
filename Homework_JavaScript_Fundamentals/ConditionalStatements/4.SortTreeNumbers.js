/*Problem 4. Sort 3 numbers

Sort 3 real values in descending order.
    Use nested if statements.
    Note: Don’t use arrays and the built-in sorting functionality.*/

function SortNumber() {
    var numberA = jsConsole.readFloat("#tb-first");
    var numberB = jsConsole.readFloat("#tb-second");
    var numberC = jsConsole.readFloat("#tb-third");
    var sortedCollection = [];
    if (numberA > numberB) {
        if (numberA > numberC) {
            if (numberB < numberC) {
                sortedCollection[0] = numberA;
                sortedCollection[1] = numberC;
                sortedCollection[2] = numberB;

            }
            else {

                sortedCollection[0] = numberA;
                sortedCollection[1] = numberB;
                sortedCollection[2] = numberC;
            }
        }
        else {
            sortedCollection[0] = numberC;
            sortedCollection[1] = numberA;
            sortedCollection[2] = numberB;
        }
    }
    else {
        if (numberB > numberC) {
            if (numberA > numberC) {
                sortedCollection[0] = numberB;
                sortedCollection[1] = numberA;
                sortedCollection[2] = numberC;
            }
            else {
                sortedCollection[0] = numberB;
                sortedCollection[1] = numberC;
                sortedCollection[2] = numberA;
            }
        }
        else {
            sortedCollection[0] = numberC;
            sortedCollection[1] = numberB;
            sortedCollection[2] = numberA;
        }
    }
  return  jsConsole.writeLine('Sorted number: ' + sortedCollection.join(', '));
}

