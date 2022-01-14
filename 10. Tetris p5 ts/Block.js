"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Block = void 0;
var Cell_1 = require("./Cell");
var Block = /** @class */ (function () {
    function Block(typeOfBlock, spawnX, wCell) {
        this.cells = [];
        this.typeOfBlock = typeOfBlock;
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
                this.cells.push(new Cell_1.Cell(spawnX - 1, 2, wCell));
                break;
            case 2: // caso L
                for (var i = 0; i < 3; i++) {
                    this.cells.push(new Cell_1.Cell(spawnX, i, wCell));
                }
                this.cells.push(new Cell_1.Cell(spawnX + 1, 2, wCell));
                break;
            case 3: // caso S
                this.cells.push(new Cell_1.Cell(spawnX, 0, wCell));
                this.cells.push(new Cell_1.Cell(spawnX, 1, wCell));
                this.cells.push(new Cell_1.Cell(spawnX + 1, 1, wCell));
                this.cells.push(new Cell_1.Cell(spawnX + 1, 2, wCell));
                break;
            case 4: // caso Z
                this.cells.push(new Cell_1.Cell(spawnX + 1, 0, wCell));
                this.cells.push(new Cell_1.Cell(spawnX + 1, 1, wCell));
                this.cells.push(new Cell_1.Cell(spawnX, 1, wCell));
                this.cells.push(new Cell_1.Cell(spawnX, 2, wCell));
                break;
            case 5: // caso T
                this.cells.push(new Cell_1.Cell(spawnX - 1, 0, wCell));
                this.cells.push(new Cell_1.Cell(spawnX, 0, wCell));
                this.cells.push(new Cell_1.Cell(spawnX + 1, 0, wCell));
                this.cells.push(new Cell_1.Cell(spawnX, 1, wCell));
                break;
            case 6: // caso O
                this.cells.push(new Cell_1.Cell(spawnX + 1, 0, wCell));
                this.cells.push(new Cell_1.Cell(spawnX, 0, wCell));
                this.cells.push(new Cell_1.Cell(spawnX + 1, 1, wCell));
                this.cells.push(new Cell_1.Cell(spawnX, 1, wCell));
                break;
        }
        this.moving = true;
    }
    Object.defineProperty(Block.prototype, "moving", {
        get: function () {
            return this._moving;
        },
        set: function (value) {
            this._moving = value;
            for (var i = 0; i < this.cells.length; i++) {
                this.cells[i].moving = value; //setta tutte le celle del blocco in movimento con moving = value
            }
        },
        enumerable: false,
        configurable: true
    });
    Block.prototype.getNextIndexOfRotate = function () {
        switch (this.typeOfBlock) {
            case 0: // caso I
                for (var i = 0; i < this.cells.length; i++) {
                }
                break;
            case 1: // caso J
                break;
            case 2: // caso L
                break;
            case 3: // caso S
                break;
            case 4: // caso Z
                break;
            case 5: // caso T
                break;
            case 6: // caso O
                break;
        }
        return new Array(1);
    };
    return Block;
}());
exports.Block = Block;
