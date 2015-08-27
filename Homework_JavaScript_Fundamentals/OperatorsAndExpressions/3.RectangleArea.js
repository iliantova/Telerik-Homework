//Problem 3. Rectangle area
//Write an expression that calculates rectangle’s area by given width and height.


function Area(){

    var width = jsConsole.readFloat("#tb-first");
    var height = jsConsole.readFloat("#tb-second");
    var area = width*height;
    jsConsole.writeLine('Rectangle’s area is : ' + area);
}

