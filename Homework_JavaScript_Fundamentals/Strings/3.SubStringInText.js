/*Problem 3. Sub-string in text

Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
Example:

    The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9*/

function getCountOfWord(text,word) {
    var count = 0;
    var index = text.indexOf(word)
    text = text.toLowerCase();
    word = word.toLowerCase();
    while(index >= 0) {
        count++;
        index = text.indexOf(word,index + 1);
    }
    return count;
}

function wordOfText(){

    var inputString = jsConsole.read("#tb-first"),
        word  = jsConsole.read("#tb-second");

    jsConsole.writeLine('The word " ' + word + ' "is contend in text: ' +getCountOfWord(inputString,word));
}