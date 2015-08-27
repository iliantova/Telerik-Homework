/*Problem 7. First larger than neighbours

Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
    Use the function from the previous exercise.*/

function firstLarger(){

    var input = jsConsole.read("#tb-first"),
        array = input.split(', ').map(function(x){return x*1;}),
        index = -1,
        i;

    for(i=0; i<array.length;i+=1){

        if(checkArrayElement(i, array)){

            index = i;
            jsConsole.writeLine('The element is on index: ' + index);
            break;
        }

    }
if (index < 0){

        jsConsole.writeLine('There is not bigger element!');
}
}








