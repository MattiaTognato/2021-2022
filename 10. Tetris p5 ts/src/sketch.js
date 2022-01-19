"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Block_1 = require("./Block");
const grid_1 = require("./grid");
const GridMoving_1 = require("./GridMoving");
var grid;
var gridMoving;
var col = 20;
var row = 10;
var wCell = 30;
var timerAuto = 0;
var timerLR = 0;
var timerDown = 0;
var keyProgressionLR = 0;
globalThis.setup = function () {
    createCanvas(row * wCell, col * wCell);
    grid = new grid_1.Grid(col, row, wCell);
    gridMoving = new GridMoving_1.GridMoving(grid, col, row, wCell);
    gridMoving.addBlock(new Block_1.Block(Math.floor(Math.random() * 7), (width / 2) / wCell, wCell));
    background(33, 66, 115);
    grid.show();
    gridMoving.show();
};
globalThis.draw = function () {
    background(33, 66, 115);
    if (millis() >= 1000 + timerAuto) {
        moveDown(); //Ogni secondo sposta il blocchetto in giù
        timerAuto = millis();
    }
    if (keyIsDown(RIGHT_ARROW)) {
        if (keyProgressionLR < 2 && millis() >= 100 + timerLR) {
            gridMoving.moveBlock("right");
            keyProgressionLR++;
            timerLR = millis();
        }
        else if (keyProgressionLR == 2 && millis() >= 50 + timerLR) {
            gridMoving.moveBlock("right");
            timerLR = millis();
        }
    }
    else if (keyIsDown(LEFT_ARROW)) {
        if (keyProgressionLR < 2 && millis() >= 150 + timerLR) {
            gridMoving.moveBlock("left");
            keyProgressionLR++;
            timerLR = millis();
        }
        else if (keyProgressionLR == 2 && millis() >= 50 + timerLR) {
            gridMoving.moveBlock("left");
            timerLR = millis();
        }
    }
    if (keyIsDown(DOWN_ARROW)) {
        if (millis() >= 50 + timerDown) {
            moveDown();
            timerDown = millis();
        }
    }
    background(33, 66, 115);
    grid.show();
    gridMoving.show();
};
function moveDown() {
    var stoppedBlockAndCreateBlock = gridMoving.movingDown(); // moving down ritorna un blocco quando un un blocco si ferma e dice se creare o no un'altro blocco
    if (stoppedBlockAndCreateBlock[1] == true && stoppedBlockAndCreateBlock[0] != undefined && stoppedBlockAndCreateBlock[0] != undefined) { //caso in cui un blocco si è fermato
        grid.addBlock(stoppedBlockAndCreateBlock[0]); // aggiungo il blocco che si è fermato alla griglia dei blocchi fermi
        gridMoving.addBlock(new Block_1.Block(Math.floor(Math.random() * 7), (width / 2) / wCell, wCell)); //aggiungo un nuovo blocco in movimento
        var fullLinesIndexes = grid.checkFullLines();
        if (fullLinesIndexes.length > 0) { //se ci sono righe piene
            grid.deleteLines(fullLinesIndexes);
        }
    }
    else if (stoppedBlockAndCreateBlock[1] == true) { //per qualche motivo non ci sono blocchi
        gridMoving.addBlock(new Block_1.Block(Math.floor(Math.random() * 7), (width / 2) / wCell, wCell)); //aggiungo un blocco in movimento in caso non ce ne siano
    }
}
globalThis.keyPressed = function () {
    if (key == "ArrowUp") {
        gridMoving.rotateBlock();
    }
};
globalThis.keyReleased = function () {
    if (key == "ArrowLeft") {
        keyProgressionLR = 0;
    }
    if (key == "ArrowRight") {
        keyProgressionLR = 0;
    }
};
//# sourceMappingURL=sketch.js.map