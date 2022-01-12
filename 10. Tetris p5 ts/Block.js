"use strict";
exports.__esModule = true;
exports.Block = void 0;
var Cell_1 = require("./Cell");
var Block = /** @class */ (function () {
    function Block(typeOfBlock, spawnX, wCell) {
        this.cells = [];
        switch (typeOfBlock) {
            case 0: // caso I
                for (var i = 0; i < 4; i++) {
                    this.cells.push(new Cell_1.Cell(spawnX, i, wCell));
                }
                break;
            case 1: // caso J
                for (var i = 0; i < 3; i++) {
                    this.cells.push(new Cell_1.Cell(spawnX, i, wCell));
                }
                this.cells.push(new Cell_1.Cell(spawnX + 1, 2, wCell));
                break;
        }
    }
    return Block;
}());
exports.Block = Block;
