/*6.Write an expression that checks if given point P(x, y) is within a circle K(O, 5).*/


function PointIn(){

    var circleRadius = 5;
    var pointX = jsConsole.readFloat("#tb-first");
    var pointY = jsConsole.readFloat("#tb-second");

    if(Math.sqrt(Math.pow(pointX, 2) + Math.pow(pointY, 2)) < circleRadius)
    {
        jsConsole.writeLine('This point is in the circle')
    }
    else{
        jsConsole.writeLine('This point is not in the circle')
    }
}
