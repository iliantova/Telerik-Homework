/*Problem 1. Increase array members

Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.*/



function increaseMembers(){
 var i,
     integersNum = 20,
     arrayNum = [];
    for(i=0; i<integersNum; i+=1){

        arrayNum[i] = i*5;
    }

    //console.log('The array is :');
    //console.log(arrayNum.join(', '));
    jsConsole.writeLine('The array is :');
    jsConsole.writeLine(arrayNum.join(', '));
}

//increaseMembers(); if prefer console