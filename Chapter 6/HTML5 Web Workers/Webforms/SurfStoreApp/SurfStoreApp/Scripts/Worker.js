var request = new XMLHttpRequest();
request.open('POST', '/statistics.svc/update', false);
request.send(null);

if (request.status == 200) {
    postMessage(request.responseText);
}	
