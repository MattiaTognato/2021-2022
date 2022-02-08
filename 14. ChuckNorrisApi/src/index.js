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
        var res = yield fetch("https://api.chucknorris.io/jokes/categories");
        var categories = yield res.json();
        var select = document.getElementById("categories");
        for (var cat in categories) {
            select.options[select.options.length] = new Option(categories[cat]);
        }
        cambioJoke();
    });
}());
function cambioJoke() {
    var p = document.getElementById("pJoke");
    var h4 = document.getElementById("categorieName");
    getJoke().then((joke) => {
        p.innerHTML = joke.value;
        h4.innerHTML = joke.categories[0];
    });
}
function getJoke() {
    return __awaiter(this, void 0, void 0, function* () {
        var select = document.getElementById('categories');
        var category = select.options[select.selectedIndex].value;
        var res = yield fetch("https://api.chucknorris.io/jokes/random?category=" + category);
        var joke = yield res.json();
        return joke;
    });
}
//# sourceMappingURL=index.js.map