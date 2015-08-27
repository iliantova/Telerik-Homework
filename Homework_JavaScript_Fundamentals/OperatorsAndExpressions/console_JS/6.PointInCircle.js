/*6.Write an expression that checks if given point P(x, y) is within a circle K(O, 5).*/

var pointX = 0;
var pointY = 1;

//var pointX = 1.5;
//var pointY = -3;

//var pointX = 0;
//var pointY = 1;

//var pointX = 100;
//var pointY = -30;

//var pointX = 0.9;
//var pointY = -4.93;


var circleRadius = 5;

function PointIn(x,y){
    if(Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2)) < circleRadius)
    {
        console.log('This point is in the circle')
    }
    else{
        console.log('This point is not in the circle')
    }
}

console.log(PointIn(pointX,pointY));