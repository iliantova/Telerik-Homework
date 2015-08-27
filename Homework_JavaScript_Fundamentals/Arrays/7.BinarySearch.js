
function binarySearch(){

    //arrayOne = [4, 7, 12, 89, 9, 3, 7, 5],
      var  stringOne = jsConsole.read("#tb-first"),
        arrayOne = stringOne.split(', ').map(function (val) { return val * 1}),
        number = jsConsole.readInteger("#tb-second"),
        i,
        index,
        numberMin = 0,
        numberMax = arrayOne.length,
        middle = arrayOne.length/2;

    arrayOne.sort(function(a, b){return a-b});

    for (i = numberMin; i < numberMax; i++)
    {
        if (arrayOne[middle] < number)
        {
            numberMin = middle + 1;
        }

        else
        {
            numberMax = middle;
        }

        if (arrayOne[i] === number)
        {
            index = i;
        }

    }

    jsConsole.writeLine('Sorted array is :' + arrayOne.join(', '));
    if(index){
        jsConsole.writeLine('Index in array is: ' + index);
    }
    else{
        jsConsole.writeLine('There have not this number in array!');
    }
    //console.log(arrayOne.join(', '));
    //console.log('Index in array is: ' + index);

}



