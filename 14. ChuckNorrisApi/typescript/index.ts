(async function bindSelect(){
    var res = await fetch("https://api.chucknorris.io/jokes/categories");
    var categories = await res.json();
    var select : HTMLSelectElement = document.getElementById("categories") as HTMLSelectElement;
    console.log(categories);
    for(var cat in categories){
        select.options[select.options.length] = new Option(categories[cat]);
    }
}())

function cambioDoggo(){
    getDogsImg().then(
        (joke) =>{
            console.log(joke)
        }
    );
}
async function getDogsImg() {
    var select:HTMLSelectElement = document.getElementById('categories') as HTMLSelectElement;
    var category = select.options[select.selectedIndex].value;
    var res = await fetch("https://api.chucknorris.io/jokes/random?category="+category);
    var joke = await res.json();
    return joke;
}
