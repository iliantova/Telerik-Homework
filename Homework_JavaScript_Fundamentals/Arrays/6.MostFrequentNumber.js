/*Problem 6. Most frequent number

Write a script that finds the most frequent number in an array.
    Example:

input	result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)*/

function mostFrequentNumber(){

    var stringOne = jsConsole.read("#tb-first"),
        arrayOne = stringOne.split(', '),
    //,arrayOne = [4, 1, 1, 1, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 1, 1, 9, 3]
        i,
        k,
        count = 0,
        countMax = 0,
        elementMax;

    for(i=0; i< arrayOne.length; i+=1){


        for(k = 0; k < arrayOne.length; k+=1){

            if(arrayOne[i]=== arrayOne[k]){
                count += 1;
                // console.log(count);
            }

        }
        if(count > countMax) {
            elementMax = arrayOne[i];
            countMax = count;
        }
        count = 0;
    }
   // console.log(elementMax);
    //console.log(countMax);

    jsConsole.writeLine('The most frequent number is : ' + elementMax);
    jsConsole.writeLine(countMax + 'time');
}
