/*Problem 6. Quadratic equation

Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
    Note: Quadratic equations may have 0, 1 or 2 real roots.*/

function findRoots(){
    var NumberA = jsConsole.readFloat("#tb-first");
    var NumberB = jsConsole.readFloat("#tb-second");
    var NumberC = jsConsole.readFloat("#tb-third");
    var result;

    var diskrim =(NumberB*NumberB -4*NumberA*NumberC);
    if(diskrim >= 0){
        var root1=(-NumberB+Math.sqrt(diskrim))/(2*NumberA);
        var root2=(-NumberB-Math.sqrt(diskrim))/(2*NumberA);

        if(root1===root2){
            result ='x1=x2='+ root1;
        }
        else {
            result ='x1='+ root1 + " x2=" + root2;
        }
    }
    else{
        result='no real roots'
    }

    jsConsole.writeLine(result);
}