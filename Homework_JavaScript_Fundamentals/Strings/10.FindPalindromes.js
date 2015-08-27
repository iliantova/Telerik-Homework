/*Problem 10. Find palindromes

Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/


function getPalindroms(text) {
    var splittedText = text.replace(/\W+/g, ' ').split(' '),
        palindromes = [];
    for(var i = 0; i < splittedText.length;i++) {
        if(checkIfPalindrom(splittedText[i])) {
            palindromes.push(splittedText[i]);
        }
    }
    return palindromes;
}
function checkIfPalindrom(word) {
    for(var i = 0; i < word.length /2; i++) {
        if(word[i] !== word[word.length - 1 - i]) {
            return false;
        }
    }
    return true;
}

function polindromsHTML(){

    var input = jsConsole.read("#tb-first"),
    result = getPalindroms(input);

    result.forEach(function (element, array){
        jsConsole.writeLine('Polindroms: ' + element);
    });


}