/*Problem 6. Larger than neighbours

Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).*/

function checkNeigh(){

    var input = jsConsole.read("#tb-first"),
        array1 = input.split(', ').map(function(x){return x*1;}),
        inputN = jsConsole.read("#tb-second"),
        number1 = inputN*1;



    jsConsole.writeLine('Is element bigger: ' + checkArrayElement(number1, array1));
   // jsConsole.writeLine('The element is not bigger!');
}

function checkArrayElement(number, array){

    if((array[number]>0) || (array[number]< array.length -1)){

        if(number == 0){

            if((array[number]> array[number+1])){

                return  true;
            }
            else{
                return false;
            }
        }
        else if(number == array.length-1 ){

            if((array[number]> array[number-1])){

                return  true;
            }
            else{
                return false;
            }
        }
        else if((array[number]> array[number+1])&&(array[number]> array[number-1])){

            return  true;
        }
        else{
            return  false;
        }
    }
    else{

        return jsConsole.writeLine('The element is out of range!');
    }

}