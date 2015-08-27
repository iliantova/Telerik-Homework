/*Problem 3. Occurrences of word

Write a function that finds all the occurrences of word in a text.
    The search can be case sensitive or case insensitive.
    Use function overloading.*/

function findWord(){

 var   text = jsConsole.read("#tb-first"),
        word = jsConsole.read("#tb-second"),
        count = 0,
     words,
     index,
        spitText = text.split(" ");

    function isMatch (word1, text1){
        if (word1 === text1){
            return true;
        }
        else{
            return false;
        }
    }

    for (index in spitText){
        words = spitText[index];
       if( isMatch(word, words)){
           count+=1;
       }
    }

    if(!count){
        jsConsole.writeLine('No matches!');
    }
    else{
        jsConsole.writeLine('The word "' + word +'" is found: ' + count + 'time');
    }
}