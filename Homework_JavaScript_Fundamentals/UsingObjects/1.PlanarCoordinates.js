/*Problem 1. Planar coordinates

Write functions for working with shapes in standard Planar coordinate system.
    Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points.
    Check if three segment lines can form a triangle.*/


function checkResult(){

    var x1 = jsConsole.readFloat("#line1-firstX"),
        y1 = jsConsole.readFloat("#line1-firstY"),
        x2 = jsConsole.readFloat("#line1-secondX"),
        y2 = jsConsole.readFloat("#line1-secondY"),
        firstSegment,
        x3 = jsConsole.readFloat("#line2-firstX"),
        y3 = jsConsole.readFloat("#line2-firstY"),
        x4 = jsConsole.readFloat("#line2-secondX"),
        y4 = jsConsole.readFloat("#line2-secondY"),
        secondSegment,
        x5 = jsConsole.readFloat("#line3-firstX"),
        y5 = jsConsole.readFloat("#line3-firstY"),
        x6 = jsConsole.readFloat("#line3-secondX"),
        y6 = jsConsole.readFloat("#line3-secondY"),
        thirdSegment;

    var pointOne = createPoint(x1, y1);
    var pointTwo = createPoint(x2, y2);
    var pointThree = createPoint(x3, y3);
    var pointFour = createPoint(x4, y4);
    var pointFive = createPoint(x5, y5);
    var pointSix = createPoint(x6, y6);


    calculateDistance(pointOne, pointTwo);
    firstSegment = createSegment(pointOne, pointTwo);

    calculateDistance(pointThree, pointFour);
    secondSegment = createSegment(pointThree, pointFour);

    calculateDistance(pointFive, pointSix);
    thirdSegment = createSegment(pointFive, pointSix);

    jsConsole.writeLine('First line: ' + firstSegment.toString());
    jsConsole.writeLine('Second line: ' + secondSegment.toString());
    jsConsole.writeLine('Third line: ' + thirdSegment.toString());
    jsConsole.writeLine('Can form triangle?: ' + canFormTriangle(firstSegment, secondSegment, thirdSegment));

}


function createPoint(x, y) {
    return {
        x: x,
        y: y,
        toString: function () {
            return ' point coordinate ' + '( ' + this.x + ', '+ this.y + ' )' ;
        }
    }
}

function createSegment(point1, point2) {
    return {
        firstPoint: point1,
        secondPoint: point2,
        toString: function () {
        return 'line coordinate - ' + this.firstPoint.toString() + ' ' + this.secondPoint.toString();
    },
        'length': calculateDistance(point1, point2)
    };
}

function calculateDistance(point1, point2) {
    return Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) +
        (point1.y - point2.y) * (point1.y - point2.y));
}

function canFormTriangle(sideA, sideB, sideC) {
    if ((sideA.length + sideB.length > sideC.length) &&
        (sideA.length + sideC.length > sideB.length) &&
        (sideB.length + sideC.length > sideA.length)) {
        return true;
    } else {
        return false;
    }
}

