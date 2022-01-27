import {} from "p5/global";
var currentImage:any;
var id:number = 1;

(globalThis as any).preload = function () {
    
};
(globalThis as any).setup = function () {
    createCanvas(200, 200);
    background(190);
    bindApi();
    noLoop();
};
(globalThis as any).draw = function (){
    background(190);
    bindApi();
};

(globalThis as any).keyPressed = function (){
    if (keyIsDown(LEFT_ARROW) && id > 1) {
        id -= 1;
    } else if (keyCode === RIGHT_ARROW) {
        id += 1;  
    }
    (globalThis as any).draw();
};

function bindApi(){
    fetch("https://pokeapi.co/api/v2/pokemon/"+id)
    .then(res => res.json())
    .then(pk => cambioPokemon(pk));
}
function cambioPokemon(pk:any){
    currentImage = loadImage(pk.sprites.front_default, success);
    textSize(32);
    text("id: "+pk.id, 10, 30);
}
let success = function() {
    image(currentImage, 50, 50);
};