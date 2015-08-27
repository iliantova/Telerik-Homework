/*Problem 6. Extract text from HTML

Write a function that extracts the content of a html page given as text.
    The function should return anything that is in a tag, without the tags.
    Example:

<html>
<head>
<title>Sample site</title>
</head>
<body>
<div>text
<div>more text</div>
and more...
</div>
in body
</body>
</html>
Result: Sample sitetextmore textand more...in body*/

function extractText(text) {
    var result = '';
    var toWrite = false;

    for (var i = 0; i < text.length; i += 1) {
        if (text[i] === '<') {
            toWrite = false;
            continue;
        }
        if (text[i] === '>') {
            toWrite = true;
            continue;
        }
        if (toWrite) {
            result += text[i];
        }
    }
    return result;
}

function htmlTextContent (){

  var  text = jsConsole.read("#tb-first");
    jsConsole.writeLine(extractText(text));

}