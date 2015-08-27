/*Problem 9. Extract e-mails

Write a function for extracting all email addresses from given text.
    All sub-strings that match the format @… should be recognized as emails.
    Return the emails as array of strings.*/

function emailGet(){
    var input = jsConsole.read("#tb-first"),
        result = '';

    var answer = extractEmails(input);

   result += 'Extracted e-mails: ' + ' ' + answer;
    jsConsole.writeLine(result);

}

function extractEmails(text){
    return text.match(/\w+@\w+\.\w+/g);
}