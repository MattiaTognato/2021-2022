"use strict";
exports.__esModule = true;
exports.Griglia = void 0;
var Griglia = /** @class */ (function () {
    function Griglia(col, row, wCell) {
        this.griglia = new Array(row);
        for (var i = 0; i < this.griglia.length; i++) {
            this.griglia[i] = new Array(col);
        }
        this.wCell = wCell;
        this.col = col;
        this.row = row;
    }
    Griglia.prototype.show = function () {
        for (var i = this.row - 1; i >= 0; i--) { //scorre tutta la griglia
            for (var j = this.col - 1; j >= 0; j--) {
                if (this.griglia[i][j] == undefined) {
                    stroke(148, 140, 117);
                    noFill();
                    strokeWeight(1);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell); //se non c'è niente disegna il quadratino
                }
                else {
                    if (this.griglia[i][j].moving != false) {
                        this.updateCell(this.griglia[i][j]);
                    }
                    fill(116, 173, 0);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell);
                }
            }
        }
        //this.updateGrid();
    };
    Griglia.prototype.addBlock = function (block) {
        this.blockMoving = block;
        for (var i = 0; i < block.cells.length; i++) {
            var cell = block.cells[i];
            this.griglia[cell.x / this.wCell][cell.y / this.wCell] = cell;
        }
    };
    Griglia.prototype.updateGrid = function () {
        var tmp = this.griglia;
        this.griglia = new Array(this.row); //nuova griglia
        for (var i = 0; i < this.griglia.length; i++) {
            this.griglia[i] = new Array(this.col);
        }
        for (var i = 0; i < this.row; i++) { //scorre tutta la griglia
            for (var j = 0; j < this.col; j++) {
                if (tmp[i][j] != undefined) { //se c'è una cella nella griglia vecchia
                    this.griglia[tmp[i][j].x / this.wCell][tmp[i][j].y / this.wCell] = tmp[i][j]; //mettila nella griglia nuova nella posizione giusta
                }
            }
        }
    };
    Griglia.prototype.updateCell = function (cell) {
        var nextIndex = (cell.y + cell.w) / this.wCell;
        if (cell.y + cell.w >= height || (this.griglia[cell.x / this.wCell][nextIndex] != undefined && this.griglia[cell.x / this.wCell][nextIndex].moving == false)) {
            cell.moving = false;
            return;
        }
        this.griglia[cell.x / this.wCell][cell.y / this.wCell] = null;
        cell.y += cell.w;
        this.griglia[cell.x / this.wCell][cell.y / this.wCell] = cell;
    };
    Griglia.prototype.moveBlock = function (n) {
        for (var i = 0; i < this.blockMoving.cells.length; i++) {
        }
    };
    return Griglia;
}());
exports.Griglia = Griglia;
