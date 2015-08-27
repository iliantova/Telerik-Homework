/*Problem 4. Number of elements

Write a function to count the number of div elements on the web page*/

function findElem(){

    function findNumberOfElement() {

        return document.getElementsByTagName('div').length;
    }
    jsConsole.writeLine('The number of divs is: ' + findNumberOfElement());
}
