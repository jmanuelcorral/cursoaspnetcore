export function httpService() {
    const HTTPHEADERS = { 'Content-Type': 'application/json' }
    const URL ="http://localhost:5000/api/alumno";
    return  {
        get : (url, callback, urlParameters) =>  {
            url = url + (urlParameters)? '/' + urlParameters: '';
            console.log(url);
            fetch(URL, {
                method : 'GET',
                headers : HTTPHEADERS
            }).then(res => res.json())
            .catch(error => console.error('Error', error))
            .then(response => {
                    console.log(`Lectura Response: ${response}`);
                    callback(response);
            });
        }
        ,
        post : (url, callback, data, urlParameters) => {
            url = url + (urlParameters)? '/' + urlParameters: '';
            fetch(url, {
                method : 'POST',
                headers : HTTPHEADERS,
                body : JSON.stringify(data)
            }).then(res => console.log(res.json()))
            .catch(error => console.error('Error', error))
            .then(response => {console.log('Sucess', response)
                callback(response);
            });
        }
    }
}

/*
function getJSON(url, callback) {
  let xhr = new XMLHttpRequest();
  xhr.onload = function () { 
    callback(this.responseText) 
  };
  xhr.open('GET', url, true);
  xhr.send();
}
*/