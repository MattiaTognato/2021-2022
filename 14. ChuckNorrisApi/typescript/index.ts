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
    var p : HTMLParagraphElement = document.getElementById("pJoke") as HTMLParagraphElement;
    var h4 : HTMLParagraphElement= document.getElementById("categorieName") as HTMLParagraphElement;
    
    getJoke().then(
        (joke) =>{
            p.innerHTML = joke.value;
            h4.innerHTML = joke.categories[0];
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
