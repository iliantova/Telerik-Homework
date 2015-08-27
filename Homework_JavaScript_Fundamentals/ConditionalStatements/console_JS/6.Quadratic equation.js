/*Problem 6. Quadratic equation

Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
    Note: Quadratic equations may have 0, 1 or 2 real roots.*/

function findRoots(){
    var NumberA = 7;
    var NumberB = 2;
    var NumberC = 5;
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
    console.log(root1);
    console.log(root2);
    return console.log(result);
}
findRoots();