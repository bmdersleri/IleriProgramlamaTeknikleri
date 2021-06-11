let response = fetch("myImage.png");
let blob = response.blob();

//-----------------------------------------------------------------------

BigInt.addEventListener('click', ()=>{

    alert('You clicked me! ');

    let pElem = document.createElement('p');
    pElem.textContent = 'This is a newly-added paragraph.';
    document.body.appendChild(pElem);

});

//-----------------------------------------------------------------------

function loadAsset(url, type, callback){
    let xhr = new XMLHttpRequest();
    xhr.open('GET', url);
    xhr.responseType = type;

    xhr.onload = function(){
        callback(xhr.response);
    };

    xhr.send();
}

function displayImage(blob){

    let objectURL = URL.createObjectURL(blob);

    let image = document.createElement('img');
    image.src = objectURL;
    document.body.appendChild(image);
}

loadAsset('coffee.jpg', 'blob', displayImage);

//-----------------------------------------------------------------------

fetch('products.json').then(function(response){
    return response.json();
}).then(function(json){
    let products = json;
    initialize(products);
}).catch(function(err){
    console.log('Fetch problem: ', err.message);
})


//-----------------------------------------------------------------------


console.log('Starting');
let image;

fetch('coffee.jpg').then((response) => {
    console.log('It worked :)')
    return response.blob();
}).then((myBlob) =>{
    let objectURL = URL.createObjectURL(myBlob);
    image = document.createElement('img');
    image.src = objectURL;
    document.body.appendChild(image);
}).catch((error) => {
    console.log('There has been a problem with your fetch operation: ' + error.message);
});

console.log('All done!');

//-----------------------------------------------------------------------

