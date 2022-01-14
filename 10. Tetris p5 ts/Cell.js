"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Cell = void 0;
var Cell = /** @class */ (function () {
    function Cell(x, y, w) {
        this.x = x * w;
        this.y = y * w;
        this.w = w;
    }
    Cell.prototype.show = function () {
        fill(0);
        rect(this.x, this.y, this.w, this.w);
    };
    return Cell;
}());
exports.Cell = Cell;
