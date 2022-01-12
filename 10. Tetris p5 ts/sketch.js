"use strict";
exports.__esModule = true;
var Block_1 = require("./Block");
var griglia_1 = require("./griglia");
var grid;
var col = 20;
var row = 10;
var widthCell = 30;
globalThis.setup = function () {
    createCanvas(row * widthCell, col * widthCell);
    grid = new griglia_1.Griglia(col, row, widthCell);
    grid.addBlock(new Block_1.Block(0, width / 2 / widthCell, widthCell));
    frameRate(1);
    while (grid.griglia.length < 1)
        ;
};
globalThis.draw = function () {
    background(33, 66, 115);
    grid.show();
};
globalThis.keyPressed = function () {
    console.log(key);
    if (key == "ArrowLeft") {
    }
    if (key == "ArrowRigth") {
    }
};
