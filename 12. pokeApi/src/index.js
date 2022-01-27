"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
Object.defineProperty(exports, "__esModule", { value: true });
var currentImage;
var id = 1;
var nextPokemon;
globalThis.preload = function () {
};
globalThis.setup = function () {
    createCanvas(200, 200);
    noLoop();
    globalThis.draw();
};
globalThis.draw = function () {
    background(190);
    apiEvoluzioni(id).then((evolution) => apiPokemon(evolution.chain.species.name).then((pokemon) => cambioPokemon(pokemon)));
};
globalThis.keyPressed = function () {
    if (keyIsDown(LEFT_ARROW) && id - 1 > 0) {
        apiEvoluzioni(id).then((evolution) => apiPokemon(evolution.chain.species.name).then((pokemon) => cambioPokemon(pokemon)));
        id -= 1;
    }
    else if (keyCode === RIGHT_ARROW) {
        apiEvoluzioni(id).then((evolution) => apiPokemon(evolution.chain.species.name).then((pokemon) => cambioPokemon(pokemon)));
        id += 1;
    }
    globalThis.draw();
};
function apiPokemon(name) {
    return __awaiter(this, void 0, void 0, function* () {
        var result = yield fetch("https://pokeapi.co/api/v2/pokemon/" + name);
        var evolution = (yield result).json();
        return yield evolution;
    });
}
function apiEvoluzioni(_id) {
    return __awaiter(this, void 0, void 0, function* () {
        var result = yield fetch("https://pokeapi.co/api/v2/evolution-chain/" + _id);
        var evolution = (yield result).json();
        return yield evolution;
    });
}
function cambioPokemon(pk) {
    background(190);
    currentImage = loadImage(pk.sprites.front_default, success);
    textSize(32);
    text("id: " + pk.id, 10, 30);
}
let success = function () {
    image(currentImage, 50, 50);
};
//# sourceMappingURL=index.js.map