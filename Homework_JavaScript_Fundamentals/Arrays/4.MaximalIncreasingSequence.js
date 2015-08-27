/*Problem 4. Maximal increasing sequence

Write a script that finds the maximal increasing sequence in an array.
    Example:

input	result
3, 2, 3, 4, 2, 2, 4	2, 3, 4*/


function increasingMaxSequence(){

   var  stringOne = jsConsole.read("#tb-first"),
        arrayOne = stringOne.split(', '),
    //arrayOne = [3, 2, 3, 4, 5, 6, 2, 2, 4], //if you prefer console
        i,
        currentArray = [arrayOne[0]],
        biggestArray = [arrayOne[0]];

       jsConsole.writeLine('Your array is :');
    jsConsole.writeLine(arrayOne.join(', '));
    for(i=0; i<arrayOne.length - 1; i+=1){

        if(arrayOne[i] <= arrayOne[i+1]){

            currentArray.push(arrayOne[i+1]);

        }
        else
        {
            if(currentArray.length > biggestArray.length){

                biggestArray = currentArray.slice();

            }
            currentArray[0] = arrayOne[i+1];
        }
    }

    //console.log(biggestArray.join(', '));
    jsConsole.writeLine('Maximal sequence of equal elements in an array');
    jsConsole.writeLine(biggestArray.join(', '));

}