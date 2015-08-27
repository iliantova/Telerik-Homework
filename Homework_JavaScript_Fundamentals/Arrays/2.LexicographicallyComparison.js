/*Problem 2. Lexicographically comparison

Write a script that compares two char arrays lexicographically (letter by letter).*/

function compareArray(){
    var stringOne = jsConsole.read("#tb-first"),
         stringTwo = jsConsole.read("#tb-second"),
         arrayOne = stringOne.split(''),
         arrayTwo = stringTwo.split(''),
        i,
        result = false;
    if (arrayOne.length == arrayTwo.length){
        for(i=0; i<arrayOne.length; i+=1){

            if(arrayOne[i]===arrayTwo[i]){
                result = true;
            }
            else {
                result = false;
                break;
            }

        }
    }
else {
        result = false;
    }

    if(result){
       // console.log('The arrays are equal');
        jsConsole.writeLine('The array are equal');
    }
else{
        //console.log('The arrays are not equal');
        jsConsole.writeLine('The array are not equal');
    }

}