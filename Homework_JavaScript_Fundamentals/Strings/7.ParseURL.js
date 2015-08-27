/*Problem 7. Parse URL

Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.
    Example:

URL	result
http://telerikacademy.com/Courses/Courses/Details/239	{ protocol: http, 
    server: telerikacademy.com
resource: /Courses/Courses/Details/239*/

function changeHTML() {
    var input = jsConsole.read("#tb-first");

    function getProtocol(url) {
        return url.substring(0,url.indexOf(':'));
    }
    function getServer(url) {
        return url.substring(url.indexOf('//') + 2,url.indexOf('/',url.indexOf('//') + 2));
    }
    function getResource(url) {
        return url.substring(url.indexOf('/',url.indexOf('//') + 2),url.length);
    }

    jsConsole.writeLine('Protocol: ' + getProtocol(input));
    jsConsole.writeLine('Server: ' + getServer(input));
    jsConsole.writeLine('Resource: ' + getResource(input));

}

