/*Problem 5. Selection sort

 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array*/

function sortArray(){

    var stringOne = jsConsole.read("#tb-first"),
        arrayOne = stringOne.split(', ').map(function(x){return x*1}),
    //arrayOne = [3, 2, 8, 4, 5, 9, 7, 1, 10],
        i,
        k,
        min,
        temp;

    for(i=0; i< arrayOne.length; i+=1){

        min = i;
        for(k = i+1; k < arrayOne.length; k+=1){

            if(arrayOne[k]<arrayOne[min]){

                min = k;
            }

        }
        if(!(min == i)){

            temp = arrayOne[i];
            arrayOne[i] = arrayOne[min];
            arrayOne[min] = temp;
        }
    }
    //console.log(arrayOne);
    jsConsole.writeLine('Ordered array');
    jsConsole.writeLine(arrayOne.join(', '));
}
