"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
(function bindSelect() {
    return __awaiter(this, void 0, void 0, function* () {
        var res = yield fetch("https://dog.ceo/api/breeds/list/all");
        var razze = yield res.json();
        var select = document.getElementById("dogList");
        for (var razza in razze.message) {
            select.options[select.options.length] = new Option(razza);
        }
    });
}());
function cambioDoggo() {
}
//# sourceMappingURL=index.js.map