(async function bindSelect(){
    var res = await fetch("https://api.chucknorris.io/jokes/categories");
    var categories = await res.json();
    var select : HTMLSelectElement = document.getElementById("categories") as HTMLSelectElement;
    for(var cat in categories){
        select.options[select.options.length] = new Option(categories[cat]);
    }
    cambioJoke();
}())

function cambioJoke(){
    var divJokes : HTMLDivElement = document.getElementById("jokes-container") as HTMLDivElement;
    
    getJoke().then(
        (joke) =>{
            let divSingleJoke:string = `<div><h4>${joke.categories[0]}</h4><p class="joke-container">${joke.value}</p></div>`;
            divJokes.innerHTML = divSingleJoke + divJokes.innerHTML;
        }
    );
}
async function getJoke() {
    var select:HTMLSelectElement = document.getElementById('categories') as HTMLSelectElement;
    var category = select.options[select.selectedIndex].value;
    var res = await fetch("https://api.chucknorris.io/jokes/random?category="+category);
    var joke = await res.json();
    return joke;
}
