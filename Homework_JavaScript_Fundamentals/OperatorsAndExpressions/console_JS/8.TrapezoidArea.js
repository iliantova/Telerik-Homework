//Problem 8. Trapezoid area
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

var sidesA = 5;
var sidesB = 7;
var height = 12;
var area;

//var sidesA = 0.222;
//var sidesB = 0.333;
//var height = 0.555;


//var sidesA = 2;
//var sidesB = 1;
//var height = 33;


//var sidesA = 100;
//var sidesB = 200;
//var height = 300;


function AreaTrapezoid (a, b, h){

    area = ((a+b)/2)*h;
    return area;
}

console.log('The area is : '+ AreaTrapezoid (sidesA, sidesB, height));