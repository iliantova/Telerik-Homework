//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.

var sequence =  [1, 8, 9, 10,2, 7];
var i;
var max = sequence[0];
var min = sequence[0];
for (i=0; i<sequence.length; i+=1){

    if(sequence[i]>max){
        max = sequence[i];
    }
    if(sequence[i]<min){
        min = sequence[i];
    }

}
console.log(max);
console.log(min);