"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Grid = void 0;
var Grid = /** @class */ (function () {
    function Grid(col, row, wCell) {
        this.col = col;
        this.row = row;
        this.wCell = wCell;
        this.grid = new Array(row);
        for (var i = 0; i < this.grid.length; i++) {
            this.grid[i] = new Array(col);
        }
    }
    Grid.prototype.show = function () {
        for (var i = 0; i < this.row; i++) {
            for (var j = 0; j < this.col; j++) {
                if (this.grid[i][j] != undefined && this.grid[i][j] != null) {
                    noStroke();
                    fill(54, 117, 106);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell); //se c'è un blocco fermo disegnalo
                }
                else {
                    stroke(148, 140, 117);
                    noFill();
                    strokeWeight(1);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell); //se non c'è niente disegna il quadratino
                }
            }
        }
    };
    Grid.prototype.addBlock = function (block) {
        for (var i = 0; i < block.cells.length; i++) {
            var cell = block.cells[i];
            this.grid[cell.x / this.wCell][cell.y / this.wCell] = cell;
        }
    };
    return Grid;
}());
exports.Grid = Grid;
