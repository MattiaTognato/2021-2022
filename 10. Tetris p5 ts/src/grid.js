"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Grid = void 0;
class Grid {
    constructor(col, row, wCell) {
        this.col = col;
        this.row = row;
        this.wCell = wCell;
        this.grid = new Array(row);
        for (var i = 0; i < this.grid.length; i++) {
            this.grid[i] = new Array(col);
        }
    }
    show() {
        for (var i = 0; i < this.row; i++) {
            for (var j = 0; j < this.col; j++) {
                if (this.grid[i][j] != undefined && this.grid[i][j] != null) {
                    this.grid[i][j].show();
                }
                else {
                    stroke(148, 140, 117);
                    noFill();
                    strokeWeight(1);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell); //se non c'è niente disegna il quadratino
                }
            }
        }
    }
    addBlock(block) {
        for (var i = 0; i < block.cells.length; i++) {
            var cell = block.cells[i];
            this.grid[cell.x / this.wCell][cell.y / this.wCell] = cell;
        }
    }
    checkFullLines() {
        var fullLines = [];
        for (var i = 0; i < this.col; i++) { //passa alla colonna dopo
            for (var j = 0; j < this.row; j++) { //passa alla riga dopo
                if (this.grid[j][i] == undefined || this.grid[j][i] == null) { //se è vuota
                    break; //passa alla colonna successiva
                }
                else if (j == this.row - 1) { //se l'ultima cella è piena
                    fullLines.push(i); //mette l'indice della cella piena (da eliminare) dentro l'array
                }
            }
        }
        return fullLines; //ritorno l'indice delle righe da eliminare
    }
    deleteLines(lineIndexes) {
        for (var j = 0; j < lineIndexes.length; j++) {
            for (var i = 0; i < this.row; i++) {
                delete this.grid[i][lineIndexes[j]];
            }
        }
        for (var k = 0; k < lineIndexes.length; k++) { //per ogni colonna eliminata
            for (var i = 0; i < lineIndexes[k]; i++) { //passa alla colonna(dell'array) dopo
                for (var j = 0; j < this.row; j++) { //passa alla riga(dell'array) dopo // minore dell'indice della riga eliminata perchè bisogna spostare solo le celle che sono sopra la riga eliminata
                    if (this.grid[j][i] == undefined || this.grid[j][i] == null) { //se è vuota
                        continue; //passa alla cella dopo
                    }
                    else {
                        this.grid[j][i].y += this.wCell;
                    }
                }
            }
        }
        this.refreshCellPosition();
    }
    refreshCellPosition() {
        var cellsInGrid = [];
        for (var i = 0; i < this.row; i++) {
            for (var j = 0; j < this.col; j++) {
                if (this.grid[i][j] != undefined && this.grid[i][j] != null) {
                    cellsInGrid.push(this.grid[i][j]);
                    delete this.grid[i][j];
                }
            }
        }
        for (var i = 0; i < cellsInGrid.length; i++) {
            this.grid[cellsInGrid[i].x / this.wCell][cellsInGrid[i].y / this.wCell] = cellsInGrid[i];
        }
    }
}
exports.Grid = Grid;
//# sourceMappingURL=grid.js.map