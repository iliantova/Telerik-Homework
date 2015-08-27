/*9. Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3)
 and out of the rectangle R(top=1, left=-1, width=6, height=2).*/


var pointX = 0;
var pointY = 1;

var centerX = 1;
var centerY = 1;
var radius = 3;


//var pointX = 4;
//var pointY = 0;

//var pointX = 2;
//var pointY = 1.5;

//var pointX = -100;
//var pointY = -100;



function inCircle(x, y) {
    return Math.pow((x - centerX), 2) + Math.pow((y - centerY), 2) < Math.pow(radius, 2);
}

function outsideRectangle(x, y){

    return (x < -1 && x > 5) && (y > -1 && y < 1);
}

console.log('The point is in the circle and outside the rectangle: ' + (inCircle(pointX, pointY) && outsideRectangle(pointX, pointY)));