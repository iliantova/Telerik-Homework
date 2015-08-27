//Problem 5. Third bit

//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
  //  The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.


 var position = 3;
 //var number = 5;
// var number = 8;
// var number = 0;
var number = 15;
// var number = 5343;
// var number = 62241;

 function getBit(number, position) {
 return (number >> position) & 1;
 };

console.log("Bit #3 = " + getBit(number, position));