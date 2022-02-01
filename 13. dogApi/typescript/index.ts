(async function bindSelect(){
    var res = await fetch("https://dog.ceo/api/breeds/list/all");
    var razze = await res.json();
    var select : HTMLSelectElement = document.getElementById("dogList") as HTMLSelectElement;
    
    for(var razza in razze.message){
        select.options[select.options.length] = new Option(razza);
    }

}())

function cambioDoggo(){

}