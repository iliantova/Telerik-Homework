//Problem 8. Trapezoid area
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

function AreaTrapezoid(){

    var sidesA = jsConsole.readFloat("#tb-first");
    var sidesB = jsConsole.readFloat("#tb-second");
    var height = jsConsole.readFloat("#tb-third");
    var area;
    area = ((sidesA+sidesB)/2)*height;
    jsConsole.writeLine('The area is : '+ area);
}

