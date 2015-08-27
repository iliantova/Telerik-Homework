/*Problem 8. Replace tags

Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
*/

function replaceAnchor(html) {
    var index = html.indexOf('<a href=');

    while (index !== -1) {
        html = replaceFrom(html, index, '<a href=', '[URL=');
        html = replaceFrom(html, index, '>', ']');
        html = replaceFrom(html, index, '</a>', '[URL]');
        index = html.indexOf('<a href=', index + 1);
    }

    return html;
}

function replaceFrom(text, index, oldStr, newStr) {
    var startString = text.substring(0, index);
    var endString = text.substring(index, text.length);
    endString = endString.replace(oldStr, newStr);

    return startString + endString;
}

function replaceTags() {

    var html = jsConsole.read("#tb-first");
    html = replaceAnchor(html);
    jsConsole.writeLine(html);
}