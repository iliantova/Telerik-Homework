/*Problem 3. Maximal sequence

Write a script that finds the maximal sequence of equal elements in an array.
    Example:

input	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2 */

function maxSequence(){

    var  stringOne = jsConsole.read("#tb-first"),
            arrayOne = stringOne.split(', '),
    //  arrayOne = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1] if you prefer console
            i,
            k,
            count,
            index,
            result =[],
            check = 0;
    jsConsole.writeLine('Your array is :');
    jsConsole.writeLine(arrayOne.join(', '));
        for(i=0; i<arrayOne.length; i+=1){

            if(arrayOne[i] === arrayOne[i+1]){
              count+=1;

                if(count > check){

                    index = arrayOne[i];
                    check = count;
                }
            }
            else
            {
                count = 1;
            }
        }

    for(k=0; k < check; k+=1){
        result[k] = index;
    }
        console.log(result.join(', '));
    jsConsole.writeLine('Maximal sequence of equal elements in an array');
        jsConsole.writeLine(result.join(', '));

}