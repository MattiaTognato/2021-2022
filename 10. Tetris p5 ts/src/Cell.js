"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Cell = void 0;
class Cell {
    constructor(x, y, w, c) {
        this.x = x * w;
        this.y = y * w;
        this.w = w;
        this._color = c;
    }
    show() {
        fill(this._color);
        rect(this.x, this.y, this.w, this.w);
    }
}
exports.Cell = Cell;
//# sourceMappingURL=Cell.js.map