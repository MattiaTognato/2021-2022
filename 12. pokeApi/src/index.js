"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var currentImage;
var id = 1;
globalThis.preload = function () {
};
globalThis.setup = function () {
    createCanvas(200, 200);
    background(190);
    bindApi();
    noLoop();
};
globalThis.draw = function () {
    background(190);
    bindApi();
};
globalThis.keyPressed = function () {
    if (keyIsDown(LEFT_ARROW) && id > 1) {
        id -= 1;
    }
    else if (keyCode === RIGHT_ARROW) {
        id += 1;
    }
    globalThis.draw();
};
function bindApi() {
    fetch("https://pokeapi.co/api/v2/pokemon/" + id)
        .then(res => res.json())
        .then(pk => cambioPokemon(pk));
}
function cambioPokemon(pk) {
    currentImage = loadImage(pk.sprites.front_default, success);
    textSize(32);
    text("id: " + pk.id, 10, 30);
}
let success = function () {
    image(currentImage, 50, 50);
};
