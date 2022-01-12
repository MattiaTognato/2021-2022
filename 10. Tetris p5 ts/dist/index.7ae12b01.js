"use strict";
exports.__esModule = true;
exports.Blocco = void 0;
var Blocco = function() {
    function Blocco1(x, y, w) {
        this.x = x * w;
        this.y = y * w;
    }
    Blocco1.prototype.show = function() {
        fill(0);
        rect(this.x, this.y, this.w, this.w);
    };
    return Blocco1;
}();
exports.Blocco = Blocco;

//# sourceMappingURL=index.7ae12b01.js.map
