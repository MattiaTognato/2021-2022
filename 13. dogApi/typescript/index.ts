(async function bindSelect(){
    var res = await fetch("https://dog.ceo/api/breeds/list/all");
    var razze = await res.json();
    var select : HTMLSelectElement = document.getElementById("dogList") as HTMLSelectElement;
    
    for(var razza in razze.message){
        select.options[select.options.length] = new Option(razza);
    }
    cambioDoggo();
}())

function cambioDoggo(){
    getDogsImg().then(
        (images) =>{
            for(let i = 0; i < 5; i++){
                var imgElement:HTMLImageElement = document.getElementById("img"+i) as HTMLImageElement;
                imgElement.src = images[Math.floor(Math.random()*(images.length-1))];
            }
        }
    );
}
async function getDogsImg() {
    var select:HTMLSelectElement = document.getElementById('dogList') as HTMLSelectElement;
    var dogName = select.options[select.selectedIndex].value;
    var res = await fetch("https://dog.ceo/api/breed/"+dogName+"/images");
    var images = await res.json();
    return images.message;
}