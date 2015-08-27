/*Problem 5. nbsp

Write a function that replaces non breaking white-spaces in a text with &nbsp;*/

function replaceWith(text, index, character) {
    return text.substr(0, index) + character + text.substring(index + 1);
};


function switchWhiteSpace(text, symbol) {
    for (var i = 0; i < text.length; i += 1) {
        if (text[i] === ' ') {
            text = replaceWith(text, i, '&nbsp;');
        }
    }
    return text;
}

function replaceText(){
    var text = jsConsole.read("#tb-first"),
        space = "&nbsp;",
        textChange = switchWhiteSpace(text, space);

    jsConsole.writeLine(textChange);

}