// Problem 1. JavaScript literals
//Assign all the possible JavaScript literals to different variables.
//Problem 3. Typeof variables
//Try typeof on all variables you created.
//Problem 4. Typeof null
//Create null, undefined variables and try typeof on them.


var int = 1337;
var float = 13.37;
var string = "l33t";
var array = ["Orange", "Apple", "Banana", "Mango"];
var userObject = {} ;
var object = {
    fruit: 'Apple',
    price: 1337
};
var bool = true;
function myFirstFunc(a, b) {
    return a * b;
}
var funcResult = myFirstFunc(13, 37);

var func = function () { };

// Problem 4) Create null, undefined variables and try typeof on them.
var nullVariable = null;
var undefinedVariable = undefined;

// Problem 3) Try typeof on all variables you created.
var variableCollection = [int, float, string, array, object, bool, func, funcResult, nullVariable, undefinedVariable];

variableCollection.forEach(function (entry) {
    console.log(entry + ' is of type ' + typeof(entry));
});