"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.GridMoving = void 0;
class GridMoving {
    constructor(gridBlockStopped, col, row, wCell) {
        this.col = col;
        this.row = row;
        this.wCell = wCell;
        this.gridBlockStopped = gridBlockStopped;
        this.gridMoving = new Array(this.row);
        for (var i = 0; i < this.gridMoving.length; i++) {
            this.gridMoving[i] = new Array(this.col);
        }
    }
    show() {
        for (var i = 0; i < this.row; i++) {
            for (var j = 0; j < this.col; j++) {
                if (this.gridMoving[i][j] != undefined || this.gridMoving[i][j] != null) {
                    this.gridMoving[i][j].show();
                }
            }
        }
    }
    addBlock(block) {
        this.blockMoving = block;
        for (var i = 0; i < block.cells.length; i++) {
            var cell = block.cells[i];
            this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = cell;
        }
    }
    movingDown() {
        if (this.blockMoving == undefined || this.blockMoving == null) {
            return [null, true];
        }
        if (this.checkIfMovableDown(this.blockMoving)) {
            for (var i = 0; i < this.blockMoving.cells.length; i++) {
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = null;
            }
            for (var i = 0; i < this.blockMoving.cells.length; i++) {
                var cell = this.blockMoving.cells[i];
                cell.y += cell.w;
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = cell;
            }
            return [null, false];
        }
        else {
            this.blockMoving.moving = false;
            var tmp = this.blockMoving;
            for (var i = 0; i < this.blockMoving.cells.length; i++) {
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = null;
            }
            this.blockMoving = null;
            return [tmp, true];
        }
    }
    checkIfMovableDown(block) {
        for (var i = 0; i < block.cells.length; i++) {
            var cell = block.cells[i];
            var nextIndex = (cell.y + cell.w) / this.wCell;
            if (cell.y + cell.w >= height || this.gridBlockStopped.grid[cell.x / this.wCell][nextIndex] != undefined || this.gridBlockStopped.grid[cell.x / this.wCell][nextIndex] != null) {
                return false;
            }
        }
        return true;
    }
    moveBlock(direzione) {
        if (this.blockMoving == undefined || this.blockMoving == null) {
            return;
        }
        if (this.checkIfMovableLR(direzione, this.blockMoving)) {
            for (var i = 0; i < this.blockMoving.cells.length; i++) {
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = null;
            }
            for (var i = 0; i < this.blockMoving.cells.length; i++) {
                var cell = this.blockMoving.cells[i];
                if (direzione == "right") {
                    cell.x += this.wCell;
                }
                else if (direzione == "left") {
                    cell.x -= this.wCell;
                }
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = cell;
            }
        }
    }
    checkIfMovableLR(direzione, block) {
        for (var i = 0; i < block.cells.length; i++) {
            var cell = block.cells[i];
            var nextIndex;
            if (direzione == "right") { //controllo se il blocco può muoversi a destra
                nextIndex = (cell.x + cell.w) / this.wCell;
                if (nextIndex * this.wCell >= width || this.gridBlockStopped.grid[nextIndex][cell.y / this.wCell] != undefined || this.gridBlockStopped.grid[nextIndex][cell.y / this.wCell] != null) {
                    return false;
                }
            }
            else if (direzione == "left") { //controllo se il blocco può muoversi a sinistra
                nextIndex = (cell.x - cell.w) / this.wCell;
                if (nextIndex * this.wCell < 0 || this.gridBlockStopped.grid[nextIndex][cell.y / this.wCell] != undefined || this.gridBlockStopped.grid[nextIndex][cell.y / this.wCell] != null) {
                    return false;
                }
            }
        }
        return true;
    }
    rotateBlock() {
        if (this.blockMoving == undefined || this.blockMoving == null) {
            return;
        }
        if (this.checkIfRotatable(this.blockMoving)) {
            this.blockMoving.rotate();
        }
    }
    checkIfRotatable(block) {
        var nextIndexes = block.getNextIndexOfRotate();
        for (var i = 0; i < nextIndexes.length; i++) {
            var cell = nextIndexes[i];
            if (cell.y + cell.w >= height || cell.x < 0 || cell.x >= width || this.gridBlockStopped.grid[cell.x / this.wCell][cell.y / this.wCell] != undefined || this.gridBlockStopped.grid[cell.x / this.wCell][cell.y / this.wCell] != null) {
                return false; //se il blocco sbatte giù || sinistra || destra || ci sono celle dove deve andare ritorna false
            }
        }
        return true; //se esce dal for tutte le celle sono ruotabili quindi ritorno true
    }
}
exports.GridMoving = GridMoving;
//# sourceMappingURL=GridMoving.js.map