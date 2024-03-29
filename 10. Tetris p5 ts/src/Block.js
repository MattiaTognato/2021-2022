"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Block = void 0;
const Cell_1 = require("./Cell");
class Block {
    constructor(typeOfBlock, spawnX, wCell) {
        this.cells = [];
        this.typeOfBlock = typeOfBlock;
        this.wCell = wCell;
        switch (this.typeOfBlock) {
            case 0: // caso I
                this.rotationShapes = [
                    [[0, 0], [0, 1], [0, 2], [0, 3]],
                    [[-1, 1], [0, 1], [1, 1], [2, 1]]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 1: // caso J
                this.rotationShapes = [
                    [[0, 0], [0, 1], [0, 2], [-1, 2]],
                    [[1, 2], [-1, 1], [0, 1], [1, 1]],
                    [[1, 0], [0, 0], [0, 1], [0, 2]],
                    [[-1, 0], [-1, 1], [0, 1], [1, 1]]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 2: // caso L
                this.rotationShapes = [
                    [[0, 0], [0, 1], [0, 2], [1, 2]],
                    [[1, 0], [-1, 1], [0, 1], [1, 1]],
                    [[-1, 0], [0, 0], [0, 1], [0, 2]],
                    [[-1, 2], [-1, 1], [0, 1], [1, 1]]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 3: // caso S
                this.rotationShapes = [
                    [[1, 0], [1, 1], [0, 1], [0, 2]],
                    [[0, 0], [1, 0], [1, 1], [2, 1]]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 4: // caso Z
                this.rotationShapes = [
                    [[0, 0], [0, 1], [1, 1], [1, 2]],
                    [[0, 1], [1, 1], [1, 0], [2, 0]]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 5: // caso T
                this.rotationShapes = [
                    [[-1, 0], [0, 0], [1, 0], [0, 1]],
                    [[0, 0], [0, 1], [0, 2], [1, 1]],
                    [[0, 0], [-1, 1], [0, 1], [1, 1]],
                    [[0, 0], [0, 1], [0, 2], [-1, 1]]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 6: // caso O
                this.rotationShapes = [
                    [[0, 0], [0, 1], [1, 0], [1, 1]]
                ];
                this.generateBlockFromShape(spawnX);
                break;
        }
        this.moving = true;
    }
    get moving() {
        return this._moving;
    }
    set moving(value) {
        this._moving = value;
        for (var i = 0; i < this.cells.length; i++) {
            this.cells[i].moving = value; //setta tutte le celle del blocco in movimento con moving = value
        }
    }
    generateBlockFromShape(spawnX) {
        this.rotation = Math.floor(Math.random() * this.rotationShapes.length);
        var tmp = Object.keys(Colors);
        var color = tmp[Math.floor(Math.random() * tmp.length)];
        for (var i = 0; i < this.rotationShapes[this.rotation].length; i++) {
            this.cells.push(new Cell_1.Cell(spawnX + this.rotationShapes[this.rotation][i][0], this.rotationShapes[this.rotation][i][1], this.wCell, color));
        }
    }
    getNextIndexOfRotate() {
        var rotatedCells = [];
        this.cells.forEach(val => rotatedCells.push(Object.assign({}, val)));
        for (var i = 0; i < rotatedCells.length; i++) { //per tutte le celle del blocco
            rotatedCells[i].x -= (this.rotationShapes[this.rotation][i][0]) * this.wCell; //sottrai la posizione relativa della cella in modo da avere tutte le celle raccolte in un blocco
            rotatedCells[i].y -= (this.rotationShapes[this.rotation][i][1]) * this.wCell;
        }
        if (this.rotation == this.rotationShapes.length - 1) { //se è all'ultima rotazione riparti dalla prima
            var nextRotation = 0;
        }
        else {
            var nextRotation = this.rotation + 1;
        }
        for (var i = 0; i < rotatedCells.length; i++) { //per tutte le celle del blocco
            rotatedCells[i].x += (this.rotationShapes[nextRotation][i][0]) * this.wCell; //somma gli indici relativi per portare i blocchi alla prossima rotazione
            rotatedCells[i].y += (this.rotationShapes[nextRotation][i][1]) * this.wCell;
        }
        return rotatedCells;
    }
    rotate() {
        var rotatedCells = this.getNextIndexOfRotate();
        for (var i = 0; i < this.cells.length; i++) {
            this.cells[i].x = rotatedCells[i].x;
            this.cells[i].y = rotatedCells[i].y;
        }
        if (this.rotation == this.rotationShapes.length - 1) { //se è all'ultima rotazione riparti dalla prima
            var nextRotation = 0;
        }
        else {
            var nextRotation = this.rotation + 1;
        }
        this.rotation = nextRotation;
    }
}
exports.Block = Block;
var Colors;
(function (Colors) {
    Colors["color1"] = "92, 250, 255";
    Colors["blue"] = "255, 61, 155";
    Colors["violet"] = "122, 0, 184";
    Colors["green"] = "4, 212, 46";
})(Colors || (Colors = {}));
//# sourceMappingURL=Block.js.map