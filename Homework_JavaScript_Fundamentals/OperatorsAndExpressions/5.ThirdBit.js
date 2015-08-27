//Problem 5. Third bit

//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
  //  The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

 function getBit() {
  var position = 3;
  var number = jsConsole.readInteger("#tb-first");
  var rezult = (number >> position) & 1;
     jsConsole.writeLine("Number in binary: " + (number >>> 0).toString(2));
     jsConsole.writeLine("Bit #3 = " + rezult);
 };

