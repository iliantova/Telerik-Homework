/*Problem 4. Lexicographically smallest
Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.*/


function findMinAndMax(object) {
    var  max = '',
        min = 'a';
    var output;
    for (var property in object) {
        if (property > max) {
            max = property;
        }
        if (property < min) {
            min = property;
        }
    }
    output='min element is: ' + min + '    and max element is: ' + max;
    jsConsole.writeLine(output);
}

function Check(){

    if(document.getElementById('r1').checked) {
        findMinAndMax(window);
    } else if(document.getElementById('r2').checked){
        findMinAndMax(navigator);
    } else if(document.getElementById('r3').checked){
        findMinAndMax(document);
    }

}
