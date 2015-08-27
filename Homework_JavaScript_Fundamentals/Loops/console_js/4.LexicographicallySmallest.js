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
    console.log(output);
}

findMinAndMax(window);
findMinAndMax(navigator);
findMinAndMax(document);