import {} from "p5/global";
var currentImage:any;
var id:number = 1;
var nextPokemon:any;
(globalThis as any).preload = function () {
    
};
(globalThis as any).setup = function () {
    createCanvas(200, 200);
    noLoop();
    (globalThis as any).draw();
};
(globalThis as any).draw = function (){
    background(190);
    apiEvoluzioni(id).then((evolution) => apiPokemon(evolution.chain.species.name).then((pokemon) => cambioPokemon(pokemon)));
};

(globalThis as any).keyPressed = function (){
    if (keyIsDown(LEFT_ARROW) && id-1 > 0) {
        apiEvoluzioni(id).then((evolution) => apiPokemon(evolution.chain.species.name).then((pokemon) => cambioPokemon(pokemon)));
        id -= 1;
    } else if (keyCode === RIGHT_ARROW) {
        apiEvoluzioni(id).then((evolution) => apiPokemon(evolution.chain.species.name).then((pokemon) => cambioPokemon(pokemon)));
        id += 1;  
    }
    (globalThis as any).draw();
};

async function apiPokemon(name:string){
    var result = await fetch("https://pokeapi.co/api/v2/pokemon/" + name)
    var evolution = (await result).json();
    return await evolution;
}
async function apiEvoluzioni(_id:number){
    var result = await fetch("https://pokeapi.co/api/v2/evolution-chain/"+_id)
    var evolution = (await result).json();
    return await evolution;
}
function cambioPokemon(pk:any){
    background(190);
    currentImage = loadImage(pk.sprites.front_default, success);
    textSize(32);
    text("id: " + pk.id, 10, 30);
}
let success = function() {
    image(currentImage, 50, 50);
};